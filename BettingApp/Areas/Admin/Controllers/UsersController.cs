using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IMemoryCache cache;

        public UsersController(IUserService _userService, IMemoryCache _cache)
        {
            userService = _userService;
            cache = _cache;
        }
            
        public async Task<IActionResult> Index()
        {
            var users = await userService.All();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(10));

            cache.Set(UsersCacheKey, users, cacheOptions);

            return View(users);
        }
    }
}
