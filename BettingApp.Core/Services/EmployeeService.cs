using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Employee;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository repo;

        public EmployeeService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<EmployeeFormModel> GetByIdAsync(int id)
        {
            var emp = await repo.All<Employee>()
                .Select(e => new EmployeeFormModel()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    BirthDate = e.BirthDate,
                    ImageUrl = e.ImageUrl,
                    CountryId = e.CountryId,
                    TeamId = e.TeamId
                })
                .FirstOrDefaultAsync();

            return emp;
        }

        public async Task EditAsync(EmployeeFormModel model)
        {
            var employee = await repo.GetByIdAsync<Employee>(model.Id);

            employee.LastName = model.LastName;
            employee.FirstName = model.FirstName;
            employee.BirthDate = model.BirthDate;
            employee.CountryId = model.CountryId;
            employee.TeamId = model.TeamId;
            employee.ImageUrl = model.ImageUrl;

            repo.Update(employee);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllAsync()
        {
            return await repo.AllReadonly<Employee>()
                .Select(e => new EmployeeViewModel()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    ImageUrl = e.ImageUrl,
                    Country = e.Country.Name
                })
                .ToListAsync();
        }

        public async Task<EmployeeViewModel> GetDetailsByIdAsync(int id)
        {
            var emp = await repo.GetByIdAsync<Employee>(id);

            return new EmployeeViewModel()
            {
                Id = emp.Id,
                Country = emp.Country.Name,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                ImageUrl = emp.ImageUrl,
                Team = emp.Team?.Name,
                TeamId = emp.TeamId
            };
        }
    }
}
