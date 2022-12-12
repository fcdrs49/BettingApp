using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Team;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;
        private readonly ICountryService countryService;

        public TeamController(ITeamService _teamService, ICountryService _countryService)
        {
            teamService = _teamService;
            countryService = _countryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return View(await teamService.AllAsync());
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

            return RedirectToAction("Teams", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await teamService.DeleteAsync(id);

            return RedirectToAction("Teams", "Admin");
        }
    }
}
