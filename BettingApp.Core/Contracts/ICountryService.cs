using BettingApp.Core.Models.Country;
using BettingApp.Core.Models.Employee;

namespace BettingApp.Core.Contracts
{
    public interface ICountryService
    {
        public Task<IEnumerable<CountryModel>> GetAllAsync();
        public Task<CountryModel> GetByIdAsync(int id);
        public Task EditAsync(CountryModel model);
        public Task CreateAsync(CountryModel model);
        public Task DeleteByIdAsync(int id);
    }
}
