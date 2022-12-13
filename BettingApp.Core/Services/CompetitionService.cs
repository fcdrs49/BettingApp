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
        private readonly ITeamService teamService;

		public CompetitionService(IRepository _repo, ITeamService _teamService)
		{
			repo = _repo;
			teamService = _teamService;
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

		public async Task<StandingViewModel> Standings(int competitionId)
		{
			var competition = await repo.GetByIdAsync<Competition>(competitionId);
			if(competition == null)
			{
				throw new InvalidOperationException("Competition with this id does not exist!");
			}
			var model = new StandingViewModel()
			{
				CompetitionId = competitionId,
				Competition = competition.Name,
				Competitions = await GetAllAsync(),
				Teams = await teamService.StandingsByCompetitionId(competitionId)
			};

			return model;
		}
	}
}
