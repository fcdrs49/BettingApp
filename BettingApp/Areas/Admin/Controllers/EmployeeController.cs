using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Employee;
using BettingApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public EmployeeController(IEmployeeService _employeeService,
            ICountryService _countryService,
            ITeamService _teamService)
        {
            employeeService = _employeeService;
            countryService = _countryService;
            teamService = _teamService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return View(await employeeService.AllAsync());
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

            return RedirectToAction("Employees", "Admin");
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

            return RedirectToAction("Employees", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await employeeService.DeleteAsync(id);
            return RedirectToAction("Employees", "Admin");
        }
    }
}
