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

        public async Task CreateAsync(CountryModel model)
        {
            var country = new Country()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl
            };

            await repo.AddAsync(country);
            await repo.SaveChangesAsync();
        }

        public async Task EditAsync(CountryModel model)
        {
            var country = await repo.GetByIdAsync<Country>(model.Id);

            country.Name = model.Name;
            country.ImageUrl = model.ImageUrl;

            repo.Update(country);
            await repo.SaveChangesAsync();
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

        public async Task<CountryModel> GetByIdAsync(int id)
        {
            return await repo.AllReadonly<Country>()
                .Select(c => new CountryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                })
                .FirstAsync();
        }
    }
}
