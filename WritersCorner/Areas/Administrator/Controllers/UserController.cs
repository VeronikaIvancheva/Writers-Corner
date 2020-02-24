using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WritersCorner.Data.Entities;
using WritersCorner.Mappers;
using WritersCorner.Service.Contracts;

namespace WritersCorner.Areas.Administrator.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            this._userServices = userServices;
        }

        public IActionResult UserIndex()
        {
            return View("BanUser");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult BanUser(string userId, int days, string banReason)
        {
            User user = _userServices.GetUser(userId);
            _userServices.BanUser(userId, days, banReason);

            var userModel = UserMapper.MapUser(user);

            return View("Detail", userModel);
        }
    }
}