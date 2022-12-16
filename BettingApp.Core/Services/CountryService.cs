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

        public async Task<IEnumerable<CountryModel>> AllAsync()
        {
            return await repo.AllReadonly<Country>()
                .Select(c => new CountryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<CountryModel> ByIdAsync(int id)
        {
            return await repo.AllReadonly<Country>()
                .Where(c => c.Id == id)
                .Select(c => new CountryModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl
                })
                .FirstAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (await repo.AllReadonly<Employee>()
                .Where(e => e.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException("Employees for this country exist!");
            }
            if (await repo.AllReadonly<Competition>()
                .Where(c => c.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException("Competitions for this country exist!");
            }
            if(await repo.AllReadonly<Team>()
                .Where(t => t.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException("Teams for this country exist!");
            }

            await repo.DeleteAsync<Country>(id);
            await repo.SaveChangesAsync();
        }
    }
}
