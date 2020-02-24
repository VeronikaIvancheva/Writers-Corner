using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WritersCorner.Data.Entities;
using WritersCorner.Mappers;
using WritersCorner.Models.UserViewModel;
using WritersCorner.Service.Contracts;

namespace WritersCorner.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            this._userService = userService;
        }

        public async Task<IActionResult>  Index(int? currentPage, string search = null)
        {
            int currentP = currentPage ?? 1;
            int totalPages = await _userService.GetPageCount(10);
                       
            IEnumerable<User> allUsers = null;

            if (!string.IsNullOrEmpty(search))
            {
                allUsers = await _userService.SearchUser(search, currentP);
            }
            else
            {
                allUsers = await _userService.GetAllUsers(currentP);
            }

            var userListing = allUsers
                .Select(u => UserMapper.MapUser(u));
            var userModel = UserMapper.MapUserIndex(userListing, currentP, totalPages);

            userModel.CurrentPage = currentP;
            userModel.TotalPages = totalPages;

            if (totalPages > currentP)
            {
                userModel.NextPage = currentP + 1;
            }
            if (currentP > 1)
            {
                userModel.PreviousPage = currentP - 1;
            }

            return View(userModel);
        }

        public IActionResult Detail(string userId)
        {
            User user = _userService.GetUser(userId);
            UserViewModel userModel = UserMapper.MapUser(user);

            return View("Detail", userModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult BanUser(string userId, int days, string banReason)
        {
            string bannedFrom = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //User user = _userService.GetUser(userId);
            User user = _userService.BanUser(userId, days, banReason, bannedFrom);

            var userModel = UserMapper.MapUser(user);

            return View("Detail", userModel);
        }
    }
}