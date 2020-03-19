using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this._context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers(int currentPage)
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

        public async Task<User> GetUser(string id)
        {
            User user = await _context.User
                    .FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<User> BanUser(string id, int days, string banReason, string bannedFrom)
        {
            User user = await _context.User
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                throw new Exception(ExceptionMessage.NoUser);
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

                    _context.SaveChanges();

                    return user;
                }
            }
            catch (Exception)
            {

                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }

            throw new Exception(ExceptionMessage.BanErrorMessage);
        }

        public async Task<User> RemoveBan(string id)
        {
            try
            {
                User user = await _context.User
                    .FirstOrDefaultAsync(u => u.Id == id);

                user.LockoutEnd = DateTime.Now;
                user.BanRemovedDate = DateTime.Now;
                user.IsBanned = false;

                _context.SaveChanges();

                return user;
            }
            catch (Exception)
            {

                throw new Exception(ExceptionMessage.GlobalErrorMessage);
            }
        }

        public async Task<IEnumerable<User>> SearchUser(string search, int currentPage)
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

        public async Task<int> GetPageCount(int usersPerPage)
        {
            int allUsers = await _context.User
                .CountAsync();

            int totalPages = (allUsers - 1) / usersPerPage + 1;

            return totalPages;
        }
    }
}
