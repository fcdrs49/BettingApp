using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BettingApp.Areas.Bookmaker.BookmakerConstants;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Controllers
{
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

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
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

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
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

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = new GameDetailsModel();
            model.Game = await gameService.DetailsByIdAsync(id);
            model.LastFiveHome = await gameService.LastNGames(5, model.Game.HomeTeam.Id);
            model.LastFiveAway = await gameService.LastNGames(5, model.Game.AwayTeam.Id);

            return View(model);
        }

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.ByIdAsync(id);

            return View(model);
        }

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
        [HttpPost]
        public async Task<IActionResult> Edit(GameFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await gameService.EditAsync(model);

            return RedirectToAction(nameof(List));
        }

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
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

        [Area("Bookmaker")]
        [Authorize(Roles = $"{BookmakerRoleName},{AdminRoleName}")]
        [HttpGet]
        public async Task<IActionResult> List([FromQuery] GameQueryModel query)
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
