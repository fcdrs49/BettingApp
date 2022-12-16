namespace BettingApp.UnitTests
{
    [TestFixture]
    public class GameServiceTests
    {
        private IRepository repo { get; set; }
        private ICompetitionService competitionService { get; set; }
        private ITeamService teamService { get; set; }
        private IGameService gameService { get; set; }
        private ICountryService countryService { get; set; }
        private IBetService betService { get; set; }
        private IGuard guard { get; set; }
        private BettingAppDbContext bettingAppDbContext { get; set; }

        [SetUp]
        public void SetUp()
        {
            guard = new Guard();
            var contextOptions = new DbContextOptionsBuilder<BettingAppDbContext>()
                .UseInMemoryDatabase("BetDb")
                .Options;

            bettingAppDbContext = new BettingAppDbContext(contextOptions);

            bettingAppDbContext.Database.EnsureDeleted();
            bettingAppDbContext.Database.EnsureCreated();
            repo = new Repository(bettingAppDbContext);
            guard = new Guard();
            countryService = new CountryService(repo, guard);
            teamService = new TeamService(repo, countryService, guard);
            competitionService = new CompetitionService(repo, teamService, guard);
            betService = new BetService(repo, guard);
            gameService = new GameService(repo, competitionService, teamService, betService, guard);
        }

        [Test]
        public async Task TestDetailsByIdAsync()
        {
            var game = new Game()
            {
                AwayRate = 1.88m,
                AwayTeamId = 5,
                CompetitionId = 1,
                DateTime = new DateTime(2021, 05, 23, 18, 0, 0),
                DrawRate = 2.47m,
                HomeRate = 7.81m,
                HomeTeamId = 1
            };
            await repo.AddAsync(game);
            await repo.SaveChangesAsync();
            var model = await gameService.DetailsByIdAsync(game.Id);

            var expectedModel = new GameViewModel()
            {
                AwayRate = 1.88m,
                AwayTeam = new TeamViewModel()
                {
                    Id = 5,
                    Name = "Brighton"
                },
                Competition = new CompetitionViewModel()
                {
                    Id = 1,
                    Name = "Premier League 2020/2021"
                },
                Date = new DateTime(2021, 05, 23, 18, 0, 0),
                DrawRate = 2.47m,
                HomeRate = 7.81m,
                HomeTeam = new TeamViewModel()
                {
                    Id = 1,
                    Name = "Arsenal"
                }
            };
            Assert.Multiple(() =>
            {
                Assert.That(model, Is.Not.Null);
                Assert.That(model.AwayRate, Is.EqualTo(expectedModel.AwayRate));
                Assert.That(model.AwayTeam.Id, Is.EqualTo(expectedModel.AwayTeam.Id));
                Assert.That(model.AwayTeam.Name, Is.EqualTo(expectedModel.AwayTeam.Name));
                Assert.That(model.Competition.Id, Is.EqualTo(expectedModel.Competition.Id));
                Assert.That(model.Competition.Name, Is.EqualTo(expectedModel.Competition.Name));
                Assert.That(model.Date, Is.EqualTo(expectedModel.Date));
                Assert.That(model.DrawRate, Is.EqualTo(expectedModel.DrawRate));
                Assert.That(model.HomeRate, Is.EqualTo(expectedModel.HomeRate));
                Assert.That(model.HomeTeam.Id, Is.EqualTo(expectedModel.HomeTeam.Id));
                Assert.That(model.HomeTeam.Name, Is.EqualTo(expectedModel.HomeTeam.Name));
            });

        }

        [Test]
        public async Task TestNextNGames()
        {
            var date = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                await repo.AddAsync(new Game()
                {
                    CompetitionId = 1,
                    AwayRate = 1,
                    AwayTeamGoals = 0,
                    AwayTeamId = i,
                    DrawRate = 1,
                    Finished = false,
                    HomeTeamId = 1,
                    Sign = ScoreSign.Draw,
                    HomeRate = 1,
                    HomeTeamGoals = 0,
                    DateTime = date.AddSeconds(i*2)
                });
            }
            var firstGame = new Game()
            {
                CompetitionId = 1,
                AwayRate = 1,
                AwayTeamGoals = 0,
                AwayTeamId = 11,
                DrawRate = 1,
                Finished = false,
                HomeTeamId = 1,
                Sign = ScoreSign.Draw,
                HomeRate = 1,
                HomeTeamGoals = 0,
                DateTime = date.AddSeconds(1)
            }; 
            var lastGame = new Game()
            {
                CompetitionId = 1,
                AwayRate = 1,
                AwayTeamGoals = 0,
                AwayTeamId = 12,
                DrawRate = 1,
                Finished = false,
                HomeTeamId = 1,
                Sign = ScoreSign.Draw,
                HomeRate = 1,
                HomeTeamGoals = 0,
                DateTime = date.AddSeconds(17)
            };

            await repo.AddAsync(firstGame);
            await repo.AddAsync(lastGame);
            await repo.SaveChangesAsync();

            var games = await gameService.NextNGames(10, 1);
            Assert.Multiple(() =>
            {
                Assert.That(games.Count(), Is.EqualTo(10));
                Assert.That(games.FirstOrDefault()?.Date, Is.EqualTo(firstGame.DateTime));
                Assert.That(games.LastOrDefault()?.Date, Is.EqualTo(lastGame.DateTime));
            });
        }

        [Test]
        public async Task TestByIdAsync()
        {
            var game = new Game()
            {
                CompetitionId = 1,
                AwayRate = 1,
                AwayTeamGoals = 0,
                AwayTeamId = 11,
                DrawRate = 1,
                Finished = false,
                HomeTeamId = 12,
                Sign = ScoreSign.Draw,
                HomeRate = 1,
                HomeTeamGoals = 0,
                DateTime = DateTime.Now.AddMinutes(30)
            };

            await repo.AddAsync(game);
            await repo.SaveChangesAsync();

            var actualGame = await gameService.ByIdAsync(game.Id);
            Assert.Multiple(() =>
            {
                Assert.That(actualGame, Is.Not.Null);
                Assert.That(actualGame.DateTime, Is.EqualTo(game.DateTime));
                Assert.That(actualGame.Id, Is.EqualTo(game.Id));
                Assert.That(actualGame.HomeTeamId, Is.EqualTo(game.HomeTeamId));
                Assert.That(actualGame.AwayTeamId, Is.EqualTo(game.AwayTeamId));
                Assert.That(actualGame.Competitions.Count, Is.AtLeast(1));
                Assert.That(actualGame.Teams.Count, Is.AtLeast(1));
            });
        }

        [Test]
        public async Task TestAllAsync()
        {
            var games = await gameService.AllAsync();

            Assert.That(games.Count(), Is.AtLeast(1));
        }

        [Test]
        public async Task TestEditAsync()
        {
            var game = new Game()
            {
                AwayRate = 1.88m,
                AwayTeamId = 5,
                CompetitionId = 1,
                DateTime = new DateTime(2021, 05, 23, 18, 0, 0),
                DrawRate = 2.47m,
                HomeRate = 7.81m,
                HomeTeamId = 1
            };
            await repo.AddAsync(game);
            await repo.SaveChangesAsync();

            var gameFormModel = new GameFormModel()
            {
                Id = game.Id,
                AwayRate = game.AwayRate,
                AwayTeamGoals = game.HomeTeamGoals,
                AwayTeamId = game.HomeTeamId,
                CompetitionId = game.CompetitionId,
                DateTime = game.DateTime,   
                DrawRate = game.DrawRate,
                HomeRate = game.HomeRate,
                HomeTeamId = game.AwayTeamId,
                Finished = !game.Finished,
                HomeTeamGoals = game.AwayTeamGoals,
                ScoreSign = game.Sign
            };
            await gameService.EditAsync(gameFormModel);
            var actualGame = await repo.GetByIdAsync<Game>(gameFormModel.Id);

            Assert.Multiple(() =>
            {
                Assert.That(actualGame, Is.Not.Null);
                Assert.That(actualGame.Id, Is.EqualTo(gameFormModel.Id));
                Assert.That(actualGame.HomeTeamId, Is.EqualTo(gameFormModel.HomeTeamId));
                Assert.That(actualGame.AwayTeamId, Is.EqualTo(gameFormModel.AwayTeamId));
                Assert.That(actualGame.HomeTeamGoals, Is.EqualTo(gameFormModel.HomeTeamGoals));
                Assert.That(actualGame.AwayTeamGoals, Is.EqualTo(gameFormModel.AwayTeamGoals));
                Assert.That(actualGame.HomeRate, Is.EqualTo(gameFormModel.HomeRate));
            });

            gameFormModel.Finished = !gameFormModel.Finished;
            await gameService.EditAsync(gameFormModel);
            actualGame = await repo.GetByIdAsync<Game>(gameFormModel.Id);

            Assert.Multiple(() =>
            {
                Assert.That(actualGame, Is.Not.Null);
                Assert.That(actualGame.Id, Is.EqualTo(gameFormModel.Id));
                Assert.That(actualGame.Finished, Is.EqualTo(gameFormModel.Finished));
            });
        }

        [Test]
        public async Task TestCreateAsync()
        {
            var model = new GameFormModel()
            {
                AwayRate = 1,
                AwayTeamGoals = 1,
                AwayTeamId = 1,
                CompetitionId = 1,
                DateTime = DateTime.Now,
                DrawRate = 1,
                Finished = false,
                HomeRate = 1,
                HomeTeamGoals = 1,
                HomeTeamId = 1,
                ScoreSign = ScoreSign.Home,
            };

            await gameService.CreateAsync(model);

            var actualGame = await repo.AllReadonly<Game>().LastAsync();

            Assert.Multiple(() =>
            {
                Assert.That(actualGame.HomeTeamId, Is.EqualTo(model.HomeTeamId));
                Assert.That(actualGame.AwayTeamId, Is.EqualTo(model.AwayTeamId));
                Assert.That(actualGame.DateTime, Is.EqualTo(model.DateTime));
            });
        }

        [Test]
        public async Task TestDeleteAsync()
        {
            var bet = new Bet()
            {
                Amount = 1,
                Cancelled = false,
                Closed = false,
                CurrencyCode = "BGN",
                DateTime = DateTime.Now,
                UserId = "981d3bf7-5f54-4f75-9840-d02831c4d150",
                WinAmount = 0,
                Won = false
            };
            await repo.AddAsync(bet);
            await repo.SaveChangesAsync();
            var gameBet = new GameBet()
            {
                BetId = bet.Id,
                BetRate = 2,
                GameId = 1,
                Prediction = ScoreSign.Home
            };
            await repo.AddAsync(gameBet);
            await repo.SaveChangesAsync();

            Assert.ThrowsAsync<InvalidOperationException>(async () => await gameService.DeleteAsync(1));

            await gameService.DeleteAsync(2);
            var actualGame = await repo.GetByIdAsync<Game>(2);
            Assert.That(actualGame, Is.Null);
        }

        [Test]
        public async Task TestLastNGames()
        {
            var date = DateTime.Now.AddSeconds(-10);
            for (int i = 1; i <= 10; i++)
            {
                await repo.AddAsync(new Game()
                {
                    CompetitionId = 1,
                    AwayRate = 1,
                    AwayTeamGoals = 0,
                    AwayTeamId = i,
                    DrawRate = 1,
                    Finished = true,
                    HomeTeamId = 1,
                    Sign = ScoreSign.Draw,
                    HomeRate = 1,
                    HomeTeamGoals = 0,
                    DateTime = date.AddSeconds(-i*2)
                });
            }
            var firstGame = new Game()
            {
                CompetitionId = 1,
                AwayRate = 1,
                AwayTeamGoals = 0,
                AwayTeamId = 1,
                DrawRate = 1,
                Finished = true,
                HomeTeamId = 11,
                Sign = ScoreSign.Draw,
                HomeRate = 1,
                HomeTeamGoals = 0,
                DateTime = date.AddSeconds(-1)
            };
            var lastGame = new Game()
            {
                CompetitionId = 1,
                AwayRate = 1,
                AwayTeamGoals = 0,
                AwayTeamId = 12,
                DrawRate = 1,
                Finished = true,
                HomeTeamId = 1,
                Sign = ScoreSign.Draw,
                HomeRate = 1,
                HomeTeamGoals = 0,
                DateTime = date.AddSeconds(-17)
            };

            await repo.AddAsync(lastGame);
            await repo.AddAsync(firstGame);
            await repo.SaveChangesAsync();

            var games = await gameService.LastNGames(10, 1);
            Assert.Multiple(() =>
            {
                Assert.That(games.Count(), Is.EqualTo(10));
                Assert.That(games.FirstOrDefault()?.Date, Is.EqualTo(firstGame.DateTime));
                Assert.That(games.LastOrDefault()?.Date, Is.EqualTo(lastGame.DateTime));
            });
        }

        [Test]
        public async Task TestAll()
        {
            var team = await repo.AllReadonly<Team>()
                .Where(t => t.Name == "Arsenal")
                .FirstAsync();

            var gamesToDelete = await repo.All<Game>()
                .ToListAsync();
            repo.DeleteRange(gamesToDelete);
            await repo.SaveChangesAsync();

            var games = await gameService.All(true, false, "Arsenal", "");
            Assert.That(games.GamesCount, Is.EqualTo(0));
            var competition = await competitionService.GetByIdAsync(1);

            for (int i = 0; i < 5; i++)
            {
                var game = new Game()
                {
                    AwayRate = 1,
                    HomeRate = 1,
                    DrawRate = 1,
                    AwayTeamId = team.Id,
                    HomeTeamId = 2,
                    DateTime = DateTime.Now.AddSeconds(i + 10),
                    CompetitionId = 1,
                    Finished = false,
                    Sign = ScoreSign.Home
                };

                await repo.AddAsync(game);
            }
            await repo.SaveChangesAsync();
            games = await gameService.All(true, false, "Arsenal", competition.Name);
            //games = await gameService.All(true, false, "Arsenal");
            Assert.Multiple(() =>
            {
                Assert.That(games.GamesCount, Is.EqualTo(5));
                Assert.That(games.Games.All(g => g.AwayTeam.Name == "Arsenal"));
                Assert.That(games.Games.All(g => g.Date > DateTime.Now));
            });
            for (int i = 0; i < 10; i++)
            {
                var game = new Game()
                {
                    AwayRate = 1,
                    HomeRate = 1,
                    DrawRate = 1,
                    AwayTeamId = team.Id + i,
                    HomeTeamId = 2,
                    DateTime = DateTime.Now.AddSeconds(i + 10),
                    CompetitionId = 1,
                    Finished = false,
                    Sign = ScoreSign.Home
                };
                await repo.AddAsync(game);
            }
            await repo.SaveChangesAsync();
            games = await gameService.All(true, false);
            Assert.Multiple(() =>
            {
                Assert.That(games.GamesCount, Is.EqualTo(15));
            });
            games = await gameService.All(true, false, "Arsenal", "", 1, 5);
            for (int i = 1; i <= 5; i++)
            {
                var game = new Game()
                {
                    AwayRate = 1,
                    HomeRate = 1,
                    DrawRate = 1,
                    AwayTeamId = team.Id,
                    HomeTeamId = 2,
                    DateTime = DateTime.Now.AddSeconds(i - (i*5)),
                    CompetitionId = 1,
                    Finished = true,
                    Sign = ScoreSign.Home
                };
                await repo.AddAsync(game);
            }
            await repo.SaveChangesAsync();
            games = await gameService.All(false, true, "", "", 1, 100);
            Assert.That(games.GamesCount, Is.EqualTo(5));
        }
    }
}
