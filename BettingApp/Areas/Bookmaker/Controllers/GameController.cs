using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BettingApp.Areas.Bookmaker.BookmakerConstants;

namespace BettingApp.Areas.Bookmaker.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = BookmakerRoleName)]
    public class GameController : Controller
    {
        private readonly IGameService gameService;
        private readonly ITeamService teamService;
        private readonly ICompetitionService competitionService;

        public GameController(IGameService _gameService, ITeamService _teamService, ICompetitionService _competitionService)
        {
            gameService = _gameService;
            teamService = _teamService;
            competitionService = _competitionService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var teams = await teamService.AllAsync();
            var competitions = await competitionService.GetAllAsync();

            var model = new GameFormModel()
            {
                Competitions = competitions,
                Teams = teams
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(GameFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await gameService.CreateAsync(model);
            return RedirectToAction("Games", "Admin");
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await gameService.DetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.ByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(GameFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await gameService.EditAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await gameService.DeleteAsync(id);
            return RedirectToAction("Games", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] GameQueryModel query)
        {
            var result = await gameService.All(
                query.TeamTerm,
                query.Competition,
                query.CurrentPage,
                GameQueryModel.GamesPerPage,
                query.Upcoming,
                query.Results);

            query.TotalGamesCount = result.GamesCount;
            query.Games = result.Games;
            query.Competitions = await competitionService.GetAllAsync();

            return View(query);
        }
    }
}
