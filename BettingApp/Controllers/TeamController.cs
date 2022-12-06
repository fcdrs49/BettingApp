using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Team;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
	public class TeamController : Controller
	{
        private readonly ITeamService teamService;
        private readonly ICountryService countryService;

        public TeamController(ITeamService _teamService, ICountryService _countryService)
        {
            teamService = _teamService;
            countryService = _countryService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await teamService.GetDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await teamService.GetByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TeamFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await teamService.EditAsync(model);

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }
    }
}
