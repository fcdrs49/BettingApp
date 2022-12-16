using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.Country;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class CountryService : ICountryService
    {

        private readonly IRepository repo;
        private readonly IGuard guard;

        public CountryService(IRepository _repo, IGuard _guard)
        {
            repo = _repo;
            guard = _guard;
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
            guard.AgainstNull(country, string.Format(ExceptionMessages.NotFound, nameof(Country), model.Id));

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
            var country = await repo.GetByIdAsync<Country>(id);
            guard.AgainstNull(country);
            return new CountryModel()
            {
                Id = country.Id,
                Name = country.Name,
                ImageUrl = country.ImageUrl
            };
        }

        public async Task DeleteAsync(int id)
        {
            var country = await ByIdAsync(id);

            if (await repo.AllReadonly<Employee>()
                .Where(e => e.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                nameof(Country),
                                country.Name,
                                nameof(Employee)));
            }
            if (await repo.AllReadonly<Competition>()
                .Where(c => c.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                nameof(Country),
                                country.Name,
                                nameof(Competition)));
            }
            if(await repo.AllReadonly<Team>()
                .Where(t => t.CountryId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                nameof(Country),
                                country.Name,
                                nameof(Team)));
            }

            await repo.DeleteAsync<Country>(id);
            await repo.SaveChangesAsync();
        }
    }
}
