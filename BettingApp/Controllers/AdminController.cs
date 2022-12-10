using BettingApp.Core.Contracts;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGameService gameService;
        private readonly ICountryService countryService;
        private readonly ICurrencyService currencyService;
        private readonly IEmployeeService employeeService;
        private readonly ITeamService teamService;

        public AdminController(
            IGameService _gameService,
            ICountryService _countryService,
            ICurrencyService _currencyService,
            IEmployeeService _employeeService,
            ITeamService _teamService)
        {
            gameService = _gameService;
            countryService = _countryService;
            currencyService = _currencyService;
            employeeService = _employeeService;
            teamService = _teamService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Games()
        {
            return View(await gameService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Countries()
        {
            return View(await countryService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Currencies()
        {
            return View(await currencyService.AllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Employees()
        {
            return View(await employeeService.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Teams()
        {
            return View(await teamService.GetAllAsync());
        }
    }
}
