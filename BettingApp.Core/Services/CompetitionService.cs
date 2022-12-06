using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Competition;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;

namespace BettingApp.Core.Services
{
	public class CompetitionService : ICompetitionService
    {
        private readonly IRepository repo;

		public CompetitionService(IRepository _repo)
		{
			repo = _repo;
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
