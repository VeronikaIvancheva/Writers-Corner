using System.Collections.Generic;
using WritersCorner.Data.Entities;
using WritersCorner.Models.UserVM;

namespace WritersCorner.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel MapUser(this User user)
        {
            var userVM = new UserViewModel
            {
                Id = user.Id,
                Username = user.UserName,
                Role = user.Role,
                Email = user.Email,
                RegisterOn = user.RegisterOn,
                BanEnd = user.LockoutEnd,
                BansCount = user.BansCount,
                BanReason = user.BanReason,
                BanDays = user.BanDays,
                BanedFrom = user.BanedFrom,
            };

            return userVM;
        }

        public static UserIndexViewModel MapUserIndex(this IEnumerable<UserViewModel> user, int currentPage, int totalPages)
        {
            var userModel = new UserIndexViewModel
            {
                CurrentPage = currentPage,
                TotalPages = totalPages,
                Users = user
            };

            return userModel;
        }
    }
}
