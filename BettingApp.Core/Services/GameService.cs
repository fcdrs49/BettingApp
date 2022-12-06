using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Competition;
using BettingApp.Core.Models.Game;
using BettingApp.Core.Models.Team;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository repo;
        private readonly ICompetitionService competitionService;

        public GameService(IRepository _repo, ICompetitionService _competitionService)
        {
            repo = _repo;
            competitionService = _competitionService;
        }
        public async Task<IEnumerable<GameViewModel>> NextTenGames()
        {
            return await repo.AllReadonly<Game>()
                .Where(g => g.DateTime > DateTime.Now)
                .OrderBy(g => g.DateTime)
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    HomeTeam = new TeamViewModel()
                    {
                        Id = g.HomeTeam.Id,
                        Name = g.HomeTeam.Name,
                        ImageUrl = g.HomeTeam.ImageUrl
                    },
                    AwayTeam = new TeamViewModel()
                    {
                        Id = g.AwayTeam.Id,
                        Name = g.AwayTeam.Name,
                        ImageUrl = g.AwayTeam.ImageUrl
                    },
                    HomeRate = g.HomeRate,
                    DrawRate = g.DrawRate,
                    AwayRate = g.AwayRate,
                    Competition = new CompetitionViewModel()
                    {
                        Id = g.Competition.Id,
                        Name = g.Competition.Name,
                        ImageUrl = g.Competition.ImageUrl
                    },
                    Date = g.DateTime.ToString("dd/MM/yyyy HH:mm")
                })
                .Take(10)
                .ToListAsync();
        }
    }
}
