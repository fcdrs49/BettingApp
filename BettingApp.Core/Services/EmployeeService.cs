using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Employee;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository repo;
        private readonly IGuard guard;

        public EmployeeService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
        }


        public async Task<EmployeeFormModel> ByIdAsync(int id)
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
                    TeamId = e.TeamId,
                    EmployeeType = e.EmployeeType
                })
                .FirstOrDefaultAsync();

            guard.AgainstNull(emp, "Employee can not be null!");
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
            employee.EmployeeType = model.EmployeeType;

            repo.Update(employee);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeViewModel>> AllAsync()
        {
            return await repo.AllReadonly<Employee>()
                .Select(e => new EmployeeViewModel()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    ImageUrl = e.ImageUrl,
                    Country = e.Country.Name,
                    CountryImageUrl = e.Country.ImageUrl,
                    Team = e.Team != null ? e.Team.Name : String.Empty
                })
                .ToListAsync();
        }

        public async Task<EmployeeViewModel> DetailsByIdAsync(int id)
        {
            var emp = await repo.AllReadonly<Employee>()
                .Include(e => e.Team)
                .Include(e => e.Country)
                .FirstOrDefaultAsync();

            guard.AgainstNull(emp, "Employee can not found!");

            return new EmployeeViewModel()
            {
                Id = emp.Id,
                Country = emp.Country.Name,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                ImageUrl = emp.ImageUrl,
                Team = emp.Team?.Name,
                TeamId = emp.TeamId,
                CountryImageUrl = emp.Country.ImageUrl
            };
        }

        public async Task CreateAsync(EmployeeFormModel model)
        {
            var employee = new Employee()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                CountryId = model.CountryId,
                EmployeeType = model.EmployeeType,
                ImageUrl = model.ImageUrl,
                TeamId = model.TeamId,
            };

            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await repo.DeleteAsync<Employee>(id);
            await repo.SaveChangesAsync();
        }
    }
}
