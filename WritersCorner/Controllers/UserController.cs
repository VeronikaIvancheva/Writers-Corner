using System;
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

        public async Task<IActionResult> Index(int? currentPage, string search = null)
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

        public async Task<IActionResult> Detail(string userId)
        {
            User user = await _userService.GetUser(userId);
            UserViewModel userModel = UserMapper.MapUser(user);

            return View("Detail", userModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> BanUser(string userId, int banDays, string banReason)
        {
            try
            {
                //TODO - to find how to clear the text in the ban form
                string bannedFrom = User.FindFirstValue(ClaimTypes.NameIdentifier);
                User user = await _userService.BanUser(userId, banDays, banReason, bannedFrom);

                var userModel = UserMapper.MapUser(user);

                return View("Detail", userModel);
            }
            catch (Exception e)
            {
                //TODO - pop-up message - not new page?
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveBan(string userId)
        {
            try
            {
                User user = await _userService.RemoveBan(userId);
                var userModel = UserMapper.MapUser(user);

                return View("Detail", userModel);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}