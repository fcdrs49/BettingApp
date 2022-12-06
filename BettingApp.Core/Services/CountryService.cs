using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Country;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class CountryService : ICountryService
    {

        private readonly IRepository repo;

        public CountryService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<CountryModel>> GetAllAsync()
        {
            return await repo.AllReadonly<Country>()
                .Select(c => new CountryModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }
    }
}
