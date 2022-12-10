using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Employee;
using BettingApp.Core.Models.Team;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
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
        public async Task<IActionResult> Edit(int id)
        {
            var model = await employeeService.GetByIdAsync(id);
            model.Countries = await countryService.GetAllAsync();
            model.Teams = await teamService.GetAllAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeFormModel model)
        {
            if(!ModelState.IsValid)
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

            model.Countries = await countryService.GetAllAsync();
            model.Teams = await teamService.GetAllAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeFormModel model)
        {
            if(!ModelState.IsValid)
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
