using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WritersCorner.Data.Context;
using WritersCorner.Data.Entities;
using WritersCorner.Service.Contracts;
using WritersCorner.Service.CustomException;

namespace WritersCorner.Service.Implementations
{
    public class UserServices : IUserServices
    {
        private readonly WritersCornerContext _context;

        public UserServices(WritersCornerContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(int currentPage)
        {
            try
            {
                IEnumerable<User> users = await _context.User
                 .OrderBy(u => u.UserName)
                 .ToListAsync();

                if (currentPage == 1)
                {
                    users = users
                         .Take(10);
                }
                else
                {
                    users = users
                        .Skip((currentPage - 1) * 10)
                        .Take(10);
                }

                return users;
            }
            catch (GlobalException)
            {

                throw new GlobalException(ExceptionMessage.NoUser);
            }
        }

        public async Task<User> GetUserAsync(string id)
        {
            try
            {
                User user = await _context.User
                    .FirstOrDefaultAsync(u => u.Id == id);

                return user;
            }
            catch (GlobalException)
            {

                throw new GlobalException(ExceptionMessage.NoUser);
            }
        }

        public async Task<User> BanUserAsync(string id, int days, string banReason, string bannedFrom)
        {
            User user = await _context.User
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoUser);
            }

            if (user.LockoutEnabled == false)
            {
                user.LockoutEnabled = true;
            }

            try
            {
                if (user.LockoutEnd == null && user.IsBanned == false)
                {
                    user.LockoutEnd = DateTime.Now.AddDays(days);
                    user.BanDays = days;
                    user.BanedFrom = bannedFrom;
                    user.BanReason = banReason;
                    user.BansCount += 1;
                    user.IsBanned = true;

                    await _context.SaveChangesAsync();

                    return user;
                }
            }
            catch (GlobalException)
            {

                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }

            throw new GlobalException(ExceptionMessage.BanErrorMessage);
        }

        public async Task<User> RemoveBanAsync(string id)
        {
            User checkUser = await _context.User
                .FirstOrDefaultAsync(u => u.Id == id);

            if (checkUser == null)
            {
                throw new ArgumentNullException(ExceptionMessage.NoUser);
            }

            try
            {
                User user = await _context.User
                    .FirstOrDefaultAsync(u => u.Id == id);

                user.LockoutEnd = DateTime.Now;
                user.BanRemovedDate = DateTime.Now;
                user.IsBanned = false;

                await _context.SaveChangesAsync();

                return user;
            }
            catch (GlobalException)
            {

                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<IEnumerable<User>> SearchUserAsync(string search, int currentPage)
        {
            try
            {
                IEnumerable<User> searchResult = await _context.User
                .Where(u => u.UserName.Contains(search) || u.Email.Contains(search))
                .OrderBy(u => u.UserName)
                .ThenBy(u => u.Email)
                .ToListAsync();

                if (currentPage == 1)
                {
                    searchResult = searchResult
                        .Take(10);
                }
                else
                {
                    searchResult = searchResult
                        .Skip((currentPage - 1) * 10)
                        .Take(10);
                }

                return searchResult;
            }
            catch (GlobalException)
            {

                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<int> GetPageCountAsync(int usersPerPage)
        {
            int allUsers = await _context.User
                .CountAsync();

            int totalPages = (allUsers - 1) / usersPerPage + 1;

            return totalPages;
        }
    }
}
