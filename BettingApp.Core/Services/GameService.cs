using BettingApp.Core.Constants;
using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
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
        private readonly ITeamService teamService;
        private readonly IBetService betService;
        private readonly IGuard guard;

        public GameService(
            IRepository _repo, 
            ICompetitionService _competitionService, 
            ITeamService _teamService,
            IBetService _betService,
            IGuard _guard)
        {
            repo = _repo;
            competitionService = _competitionService;
            teamService = _teamService;
            betService = _betService;
            guard = _guard;
        }

        public async Task<GameViewModel> DetailsByIdAsync(int id)
        {
            var model = await repo.AllReadonly<Game>()
                .Where(g => g.Id == id)
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
                    Date = g.DateTime,
                    HomeGoals = g.HomeTeamGoals,
                    AwayGoals = g.AwayTeamGoals
                })
                .FirstOrDefaultAsync();

            guard.AgainstNull(model, string.Format(ExceptionMessages.NotFound, nameof(Game), id));
            return model;
        }


        public async Task<IEnumerable<GameViewModel>> NextNGames(int count, int teamId)
        {
            var games = repo.AllReadonly<Game>();

            if(teamId > 0)
            {
                games = games.Where(g => g.HomeTeamId == teamId || g.AwayTeamId == teamId);
            }

            games = games.Where(g => g.DateTime > DateTime.Now && g.Finished == false);

            return await games
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
                    Date = g.DateTime,
                    HomeGoals = g.HomeTeamGoals,
                    AwayGoals = g.AwayTeamGoals
                })
                .Take(count)
                .ToListAsync();
        }

        public async Task<GameFormModel> ByIdAsync(int id)
        {
            var game = await repo.GetByIdAsync<Game>(id);
            guard.AgainstNull(game);
            var teams = await teamService.AllAsync();
            var competitions = await competitionService.GetAllAsync();

            var gameModel = new GameFormModel()
            {
                Id = game.Id,
                HomeTeamId = game.HomeTeamId,
                AwayTeamId = game.AwayTeamId,
                HomeRate = game.HomeRate,
                DrawRate = game.DrawRate,
                AwayRate = game.AwayRate,
                CompetitionId = game.CompetitionId,
                DateTime = game.DateTime,
                AwayTeamGoals = game.AwayTeamGoals,
                HomeTeamGoals = game.HomeTeamGoals,
                Finished = game.Finished,
                Competitions = competitions,
                Teams = teams
            };

            return gameModel;
            
        }

        public async Task<IEnumerable<GameListModel>> AllAsync()
        {
            return await repo.AllReadonly<Game>()
                .Select(g => new GameListModel()
                {
                    Id = g.Id,
                    Competition = g.Competition.Name,
                    HomeTeam = g.HomeTeam.Name,
                    AwayTeam = g.AwayTeam.Name,
                    HomeRate = g.HomeRate,
                    DrawRate = g.DrawRate,
                    AwayRate = g.AwayRate,
                    Date = g.DateTime
                })
                .ToListAsync();
        }

        public async Task EditAsync(GameFormModel model)
        {
            var game = await repo.GetByIdAsync<Game>(model.Id);
            guard.AgainstNull(game, string.Format(ExceptionMessages.NotFound, nameof(Game), model.Id));

            if(model.Finished && !game.Finished)
            {
                await betService.UpdateBetsWhenGameFinished(model);
            }
            else if (!model.Finished && game.Finished)
            {
                await betService.UpdateBetsWhenGameCorrected(model);
            }

            game.AwayRate = model.AwayRate;
            game.AwayTeamId = model.AwayTeamId;
            game.AwayTeamGoals = model.AwayTeamGoals;
            game.CompetitionId = model.CompetitionId;
            game.DateTime = model.DateTime;
            game.DrawRate = model.DrawRate;
            game.Finished = model.Finished;
            game.HomeRate = model.HomeRate;
            game.HomeTeamGoals = model.HomeTeamGoals;
            game.HomeTeamId = model.HomeTeamId;
            game.Sign = model.ScoreSign;

            repo.Update(game);
            await repo.SaveChangesAsync();
        }

        public async Task CreateAsync(GameFormModel model)
        {
            var game = new Game()
            {
                AwayRate = model.AwayRate,
                AwayTeamId = model.AwayTeamId,
                AwayTeamGoals = model.AwayTeamGoals,
                CompetitionId = model.CompetitionId,
                DateTime = model.DateTime,
                DrawRate = model.DrawRate,
                Finished = model.Finished,
                HomeRate = model.HomeRate,
                HomeTeamGoals = model.HomeTeamGoals,
                HomeTeamId = model.HomeTeamId,
                Sign = model.ScoreSign
            };

            await repo.AddAsync(game);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if(await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == id)
                .AnyAsync())
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.EntityExistsMessageOnDelete,
                                  nameof(Bet),
                                  id,
                                  nameof(GameBet)));
            }

            await repo.DeleteAsync<Game>(id);
            await repo.SaveChangesAsync();
        }

        public async Task<GameQueryServiceModel> All(bool upcoming, bool results, string team = "", string competition = "", int currentPage = 1, int gamesPerPage = 20)
        {
            var result = new GameQueryServiceModel();
            var games = repo.AllReadonly<Game>();
            if (upcoming)
            {
                games = games
                    .Where(g => g.DateTime >= DateTime.Now);
            }

            if(results)
            {
                games = games
                    .Where(g => g.DateTime < DateTime.Now)
                    .OrderByDescending(g => g.DateTime);
            }

            if(!string.IsNullOrEmpty(team))
            {
                var teamTerm = $"%{team.ToLower()}%";
                games = games
                    .Where(g => EF.Functions.Like(g.HomeTeam.Name.ToLower(),teamTerm) ||
                        EF.Functions.Like(g.AwayTeam.Name.ToLower(),teamTerm));
            }

            if(!string.IsNullOrEmpty(competition))
            {
                games = games
                    .Where(g => g.Competition.Name == competition);
            }

            result.Games = await games
                .Skip((currentPage - 1) * gamesPerPage)
                .Take(gamesPerPage)
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    HomeTeam = new TeamViewModel()
                    {
                        Id = g.HomeTeamId,
                        Name = g.HomeTeam.Name,
                        ImageUrl = g.HomeTeam.ImageUrl,
                        Country = g.HomeTeam.Country.Name
                    },
                    AwayTeam = new TeamViewModel()
                    {
                        Id = g.AwayTeamId,
                        Name = g.AwayTeam.Name,
                        ImageUrl = g.AwayTeam.ImageUrl,
                        Country = g.AwayTeam.Country.Name
                    },
                    Competition = new CompetitionViewModel()
                    {
                        Id = g.Competition.Id,
                        ImageUrl = g.Competition.ImageUrl,
                        Name = g.Competition.Name
                    },
                    Date = g.DateTime,
                    HomeRate = g.HomeRate,
                    DrawRate = g.DrawRate,
                    AwayRate = g.AwayRate,
                    HomeGoals = g.HomeTeamGoals,
                    AwayGoals = g.AwayTeamGoals
                })
                .ToListAsync();

            result.GamesCount = await games.CountAsync();

            return result;
        }

        public async Task<IEnumerable<GameViewModel>> LastNGames(int count, int teamId)
        {
            var games = repo.AllReadonly<Game>();
            if(teamId != 0)
            {
                games = games.Where(g => g.HomeTeamId == teamId || g.AwayTeamId == teamId);
            }

            games = games.Where(g => g.DateTime < DateTime.Now && g.Finished == true);

            return await games
                .Include(g => g.HomeTeam)
                .Include(g => g.AwayTeam)
                .OrderByDescending(g => g.DateTime)
                .Take(count)
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    HomeTeam = new TeamViewModel()
                    {
                        Id = g.HomeTeamId,
                        Name = g.HomeTeam.Name,
                        ImageUrl = g.HomeTeam.ImageUrl
                    },
                    AwayTeam = new TeamViewModel()
                    {
                        Id = g.AwayTeamId,
                        Name = g.AwayTeam.Name,
                        ImageUrl = g.AwayTeam.ImageUrl
                    },
                    HomeGoals = g.HomeTeamGoals,
                    AwayGoals = g.AwayTeamGoals,
                    Date = g.DateTime
                })
                .ToListAsync();
        }
    }
}
