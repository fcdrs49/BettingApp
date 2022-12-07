using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Season;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly IRepository repo;

        public SeasonService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task CreateAsync(SeasonModel model)
        {
            var season = new Season()
            {
                Code = model.Code
            };

            await repo.AddAsync(season);
            await repo.SaveChangesAsync();
        }

        public async Task EditAsync(SeasonModel model)
        {
            var season = await repo.GetByIdAsync<Season>(model.Id);

            season.Code = model.Code;
        }

        public async Task<IEnumerable<SeasonModel>> GetAllAsync()
        {
            return await repo.AllReadonly<Season>()
                .Select(s => new SeasonModel()
                {
                    Code = s.Code
                })
                .ToListAsync();
        }

        public async Task<SeasonModel> GetByIdAsync(int id)
        {
            var season = await repo.GetByIdAsync<Season>(id);

            return new SeasonModel()
            {
                Id = season.Id,
                Code = season.Code
            };
        }
    }
}
