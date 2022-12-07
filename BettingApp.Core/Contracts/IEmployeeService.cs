using BettingApp.Core.Models.Employee;

namespace BettingApp.Core.Contracts
{
    public interface IEmployeeService
    {
        public Task<EmployeeFormModel> GetByIdAsync(int id);
        public Task<EmployeeViewModel> GetDetailsByIdAsync(int id);
        public Task EditAsync(EmployeeFormModel model);
        public Task<IEnumerable<EmployeeViewModel>> GetAllAsync();
        public Task CreateAsync(EmployeeFormModel model);
    }
}
