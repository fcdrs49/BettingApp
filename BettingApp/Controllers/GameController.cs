using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var teams = await teamService.GetAllAsync();
            var competitions = await competitionService.GetAllAsync();

            var model = new GameFormModel()
            {
                Competitions = competitions,
                Teams = teams
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(GameFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await gameService.CreateAsync(model);
            return RedirectToAction("Games", "Admin");
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var model = await gameService.ViewByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.FormByIdAsync(id);

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(GameFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await gameService.EditAsync(model);

            return RedirectToAction(nameof(Details), new { Id = model.Id });
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
