using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Competition;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
	public class CompetitionService : ICompetitionService
    {
        private readonly IRepository repo;

		public CompetitionService(IRepository _repo)
		{
			repo = _repo;
		}

		public async Task<IEnumerable<CompetitionViewModel>> GetAllAsync()
		{
			return await repo.AllReadonly<Competition>()
				.Select(c => new CompetitionViewModel()
				{
					Id = c.Id,
					Name = c.Name,
					ImageUrl = c.ImageUrl
				})
				.ToListAsync();
		}

		public async Task<CompetitionViewModel> GetByIdAsync(int id)
		{
			var competition = await repo.GetByIdAsync<Competition>(id);

			return new CompetitionViewModel()
			{
				Id = competition.Id,
				Name = competition.Name,
				ImageUrl = competition.ImageUrl
			};
		}
	}
}
