using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Team;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;
        private readonly ICountryService countryService;
        private readonly IMemoryCache cache;

        public TeamController(ITeamService _teamService, ICountryService _countryService, IMemoryCache _cache)
        {
            teamService = _teamService;
            countryService = _countryService;
            cache = _cache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var teams = await teamService.AllAsync();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(60));

            cache.Set(TeamsCacheKey, teams, cacheOptions);

            return View(teams);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await teamService.ByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TeamFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await teamService.EditAsync(model);

            cache.Remove(TeamsCacheKey);


            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var team = new TeamFormModel();
            team.Countries = await countryService.AllAsync();
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TeamFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await teamService.AddAsync(model);

            cache.Remove(TeamsCacheKey);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await teamService.DeleteAsync(id);

            cache.Remove(TeamsCacheKey);

            return RedirectToAction(nameof(All));
        }

    }
}
