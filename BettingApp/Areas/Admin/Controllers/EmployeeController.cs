using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Employee;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static BettingApp.Areas.Admin.AdminConstants;
namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly ICountryService countryService;
        private readonly ITeamService teamService;
        private readonly IMemoryCache cache;

        public EmployeeController(IEmployeeService _employeeService,
            ICountryService _countryService,
            ITeamService _teamService,
            IMemoryCache _cache)
        {
            employeeService = _employeeService;
            countryService = _countryService;
            teamService = _teamService;
            cache = _cache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var employees = await employeeService.AllAsync();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(1440));

            cache.Set(EmployeesCacheKey, employees, cacheOptions);

            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await employeeService.ByIdAsync(id);
            model.Countries = await countryService.AllAsync();
            model.Teams = await teamService.AllAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await employeeService.EditAsync(model);

            cache.Remove(EmployeesCacheKey);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EmployeeFormModel();

            model.Countries = await countryService.AllAsync();
            model.Teams = await teamService.AllAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await employeeService.CreateAsync(model);

            cache.Remove(EmployeesCacheKey);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await employeeService.DeleteAsync(id);

            cache.Remove(EmployeesCacheKey);

            return RedirectToAction(nameof(All));
        }
    }
}
