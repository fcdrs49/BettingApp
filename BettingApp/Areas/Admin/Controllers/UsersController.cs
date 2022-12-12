using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        [Route("Users/All")]
        public async Task<IActionResult> Index()
        {
            return View(await userService.All());
        }
    }
}
