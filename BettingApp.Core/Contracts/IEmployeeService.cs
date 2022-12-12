using BettingApp.Core.Models.Employee;

namespace BettingApp.Core.Contracts
{
    public interface IEmployeeService
    {
        public Task<EmployeeFormModel> ByIdAsync(int id);
        public Task<EmployeeViewModel> DetailsByIdAsync(int id);
        public Task EditAsync(EmployeeFormModel model);
        public Task<IEnumerable<EmployeeViewModel>> AllAsync();
        public Task CreateAsync(EmployeeFormModel model);
        public Task DeleteAsync(int id);
    }
}
