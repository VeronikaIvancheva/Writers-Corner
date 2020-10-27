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
                IEnumerable<User> users = _context.User
                 .OrderBy(u => u.UserName);

                IEnumerable<User> distributedResult = DistributeUsersPerPage(currentPage, users);

                return distributedResult.ToList();
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
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
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.NoUser);
            }
        }

        public async Task<User> BanUserAsync(string id, int days, string banReason, string bannedFrom)
        {
            User user = await _context.User
                .FirstOrDefaultAsync(u => u.Id == id);

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
                //TODO - To add LOGGING for the errors
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
                throw new GlobalException(ExceptionMessage.NoUser);
            }

            try
            {
                checkUser.LockoutEnd = DateTime.Now;
                checkUser.BanRemovedDate = DateTime.Now;
                checkUser.IsBanned = false;

                await _context.SaveChangesAsync();

                return checkUser;
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<IEnumerable<User>> SearchUserAsync(string search, int currentPage)
        {
            try
            {
                IEnumerable<User> searchResult = _context.User
                .Where(u => u.UserName.Contains(search) || u.Email.Contains(search))
                .OrderBy(u => u.UserName)
                .ThenBy(u => u.Email);

                IEnumerable<User> distributedResult = DistributeUsersPerPage(currentPage, searchResult);

                return distributedResult.ToList();
            }
            catch (GlobalException)
            {
                //TODO - To add LOGGING for the errors
                throw new GlobalException(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<int> GetPageCountAsync()
        {
            int usersPerPage = 10;

            int allUsers = await _context.User
                .CountAsync();

            int totalPages = (allUsers - 1) / usersPerPage + 1;

            return totalPages;
        }

        private IEnumerable<User> DistributeUsersPerPage(int currentPage, IEnumerable<User> users)
        {
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
    }
}
