namespace BettingApp.UnitTests
{
    [TestFixture]
    public class BetServiceTests
    {
        private IRepository repo { get; set; }
        private IGuard guard { get; set; }
        private IBetService betService { get; set; }
        private IGameService gameService { get; set; }
        private ITeamService teamService { get; set; }
        private ICountryService countryService { get; set; }
        private ICompetitionService competitionService { get; set; }
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
            betService = new BetService(repo, guard);
            countryService = new CountryService(repo, guard);
            teamService = new TeamService(repo, countryService, guard);
            competitionService = new CompetitionService(repo, teamService, guard);
            gameService = new GameService(repo, competitionService, teamService, betService, guard);
        }

        [Test]
        public async Task TestCreateBetAsync()
        {
            List<GameBetViewModel> gameBetModels = new List<GameBetViewModel>();
            gameBetModels.Add(new GameBetViewModel()
            {
                GameId = 1,
                BetRate = 2.5m,
                Prediction = "1"
            });
            gameBetModels.Add(new GameBetViewModel()
            {
                GameId = 968415,
                BetRate = 2,
                Prediction = "X"
            });

            var userId = "c8ff8bd9-e302-488e-a71e-58418f19ded9";
            var model = new BetQueryModel()
            {
                Amount = 10,
                GameBets = gameBetModels
            };

            await betService.CreateBetAsync(model, userId);

            var bet = await repo.GetByIdAsync<Bet>(1);
            var gameBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.BetId == 1)
                .ToListAsync();

            Assert.That(gameBets.Count, Is.EqualTo(2));
            Assert.That(bet.Amount, Is.EqualTo(10));
            model.GameBets = new List<GameBetViewModel>();
            Assert.ThrowsAsync<InvalidOperationException>(async () => await betService.CreateBetAsync(model, userId));
        }

        [Test]
        public async Task TestGetBetsAmount()
        {
            await repo.AddAsync(new Bet()
            {
                Id = 1,
                Amount = 10,
                Cancelled = false,
                Closed = false,
                CurrencyCode = "BGN",
                DateTime = DateTime.Now,
                UserId = "c8ff8bd9-e302-488e-a71e-58418f19ded9",
                WinAmount = 50,
                Won = true
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 1,
                BetRate = 2,
                Prediction = ScoreSign.Away
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 2,
                BetRate = 2.5m,
                Prediction = ScoreSign.Draw
            });
            await repo.SaveChangesAsync();

            var betsAmount = betService.GetBetsAmount("c8ff8bd9-e302-488e-a71e-58418f19ded9");

            Assert.That(betsAmount, Is.EqualTo(40));
        }

        [Test]
        public async Task TestGetUserBets()
        {
            await repo.AddAsync(new Bet()
            {
                Id = 1,
                Amount = 10,
                Cancelled = false,
                Closed = false,
                CurrencyCode = "BGN",
                DateTime = DateTime.Now,
                UserId = "c8ff8bd9-e302-488e-a71e-58418f19ded9",
                WinAmount = 50,
                Won = true
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 1,
                BetRate = 2,
                Prediction = ScoreSign.Away
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 2,
                BetRate = 2.5m,
                Prediction = ScoreSign.Draw
            });
            await repo.SaveChangesAsync();

            var bets = await betService.GetUserBets("c8ff8bd9-e302-488e-a71e-58418f19ded9");

            Assert.That(bets.Count(), Is.EqualTo(1));
            Assert.That(bets.FirstOrDefault()?.GamesCount, Is.EqualTo(2));
            Assert.That(bets.FirstOrDefault()?.BetRate, Is.EqualTo(5));
        }

        [Test]
        public async Task TestGetGameBets()
        {
            await repo.AddAsync(new Bet()
            {
                Id = 1,
                Amount = 10,
                Cancelled = false,
                Closed = false,
                CurrencyCode = "BGN",
                DateTime = DateTime.Now,
                UserId = "c8ff8bd9-e302-488e-a71e-58418f19ded9",
                WinAmount = 50,
                Won = true
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 1,
                BetRate = 2,
                Prediction = ScoreSign.Away
            });
            await repo.AddAsync(new GameBet()
            {
                BetId = 1,
                GameId = 2,
                BetRate = 2.5m,
                Prediction = ScoreSign.Draw
            });
            await repo.SaveChangesAsync();

            var gameBets = await betService.GetGameBets(1);

            Assert.That(gameBets.Count(), Is.EqualTo(2));
            Assert.That(gameBets.FirstOrDefault()?.HomeTeam, Is.EqualTo("Arsenal"));
            Assert.That(gameBets.LastOrDefault()?.AwayTeam, Is.EqualTo("Chelsea"));
        }

        [Test]
        public async Task TestCancelBet()
        {
            var currency = await repo.AllReadonly<Currency>()
                .Where(c => c.ISOCode == "BGN")
                .FirstAsync();
            var user = await repo.AllReadonly<User>()
                .FirstOrDefaultAsync();
            var team = await repo.AllReadonly<Team>()
                .Take(2)
                .ToArrayAsync();
            var competition = await repo.AllReadonly<Competition>()
                .FirstOrDefaultAsync();
            var bet = new Bet()
            {
                Amount = 50,
                Cancelled = false,
                CurrencyCode = currency.ISOCode,
                Closed = false,
                DateTime = DateTime.Now,
                UserId = user.Id,
                WinAmount = 0,
                Won = false
            };
            await repo.AddAsync(bet);

            var game = new Game()
            {
                AwayRate = 3,
                HomeRate = 1.5m,
                DrawRate = 2,
                AwayTeamId = team[1].Id,
                HomeTeamId = team[0].Id,
                DateTime = DateTime.Now.AddHours(2),
                CompetitionId = competition.Id,
                Finished = false,
                HomeTeamGoals = 0,
                AwayTeamGoals = 0,
                Sign = ScoreSign.Draw
            };
            await repo.AddAsync(game);
            await repo.SaveChangesAsync();
            var gameBet = new GameBet()
            {
                BetId = bet.Id,
                BetRate = 2,
                GameId = game.Id,
                Prediction = ScoreSign.Draw,
                Won = false
            };
            await repo.AddAsync(gameBet);
            await repo.SaveChangesAsync();
            await betService.CancelBet(bet.Id);
            bet = await repo.AllReadonly<Bet>()
                .Where(b => b.Id == bet.Id)
                .FirstAsync();

            Assert.That(bet.Cancelled, Is.EqualTo(true));
        }

        [Test]
        public async Task TestUpdateBetsWhenGameFinished()
        {

            var currency = await repo.AllReadonly<Currency>()
                .Where(c => c.ISOCode == "BGN")
                .FirstAsync();
            var user = await repo.AllReadonly<User>()
                .FirstOrDefaultAsync();
            var team = await repo.AllReadonly<Team>()
                .Take(2)
                .ToArrayAsync();
            var competition = await repo.AllReadonly<Competition>()
                .FirstOrDefaultAsync();

            var game = new Game()
            {
                AwayRate = 3,
                HomeRate = 1.5m,
                DrawRate = 2,
                AwayTeamId = team[1].Id,
                HomeTeamId = team[0].Id,
                DateTime = DateTime.Now.AddHours(2),
                CompetitionId = competition.Id,
                Finished = false,
                HomeTeamGoals = 0,
                AwayTeamGoals = 0,
                Sign = ScoreSign.Draw
            }; 
            var game2 = new Game()
            {
                AwayRate = 3,
                HomeRate = 1.5m,
                DrawRate = 2,
                AwayTeamId = team[1].Id,
                HomeTeamId = team[0].Id,
                DateTime = DateTime.Now.AddHours(2),
                CompetitionId = competition.Id,
                Finished = false,
                HomeTeamGoals = 0,
                AwayTeamGoals = 0,
                Sign = ScoreSign.Draw
            };
            await repo.AddAsync(game);
            await repo.AddAsync(game2);
            var bet = new Bet()
            {
                Amount = 50,
                Cancelled = false,
                CurrencyCode = currency.ISOCode,
                Closed = false,
                DateTime = DateTime.Now,
                UserId = user.Id,
                WinAmount = 0,
                Won = false
            };
            await repo.AddAsync(bet);
            await repo.SaveChangesAsync();
            var gameBetDraw = new GameBet()
            {
                BetId = bet.Id,
                BetRate = 2,
                GameId = game.Id,
                Prediction = ScoreSign.Draw,
                Won = false
            };
            await repo.AddAsync(gameBetDraw); 
            var gameBetDraw2 = new GameBet()
            {
                BetId = bet.Id,
                BetRate = 2,
                GameId = game2.Id,
                Prediction = ScoreSign.Draw,
                Won = true
            };
            await repo.AddAsync(gameBetDraw2);
            var bet2 = new Bet()
            {
                Amount = 50,
                Cancelled = false,
                CurrencyCode = currency.ISOCode,
                Closed = false,
                DateTime = DateTime.Now,
                UserId = user.Id,
                WinAmount = 0,
                Won = false
            };
            await repo.AddAsync(bet2);
            await repo.SaveChangesAsync();
            var gameBetAway = new GameBet()
            {
                BetId = bet2.Id,
                BetRate = 2,
                GameId = game.Id,
                Prediction = ScoreSign.Away,
                Won = false
            };
            await repo.AddAsync(gameBetAway);
            await repo.SaveChangesAsync();
            var gameFormModel = await gameService.ByIdAsync(game.Id);
            bettingAppDbContext.ChangeTracker.Clear();
            gameFormModel.ScoreSign = ScoreSign.Draw;
            gameFormModel.Finished = true;
            await betService.UpdateBetsWhenGameFinished(gameFormModel);
            var test = await repo.AllReadonly<GameBet>().ToListAsync();
            gameBetDraw = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id && gb.BetId == bet.Id)
                .FirstAsync();
            gameBetAway = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id && gb.BetId == bet2.Id)
                .FirstAsync();
            Assert.That(gameBetDraw.Won, Is.True);
            Assert.That(gameBetAway.Won, Is.False);
            bet = await repo.GetByIdAsync<Bet>(bet.Id);
            Assert.That(bet.Won, Is.True);

            bettingAppDbContext.ChangeTracker.Clear();
            gameFormModel.Finished = false;
            await betService.UpdateBetsWhenGameCorrected(gameFormModel);
            gameBetDraw = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id && gb.BetId == bet.Id)
                .FirstAsync();
            gameBetAway = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.GameId == game.Id && gb.BetId == bet2.Id)
                .FirstAsync();
            Assert.That(gameBetDraw.Won, Is.False);
            Assert.That(gameBetAway.Won, Is.False);
        }

        [Test]
        public void TestAddBetGameToCollection()
        {
            var gameBetViewModels = new List<GameBetViewModel>()
            {
                new GameBetViewModel()
                {
                    HomeTeam = "Arsenal",
                    AwayTeam = "Brentford",
                    BetRate = 2,
                    Prediction = "1",
                    GameId = 5
                }
            };

            var updateExistingModel = new GameBetViewModel()
            {
                HomeTeam = "Arsenal",
                AwayTeam = "Brentford",
                BetRate = 2,
                Prediction = "2",
                GameId = 5
            };

            var addNewModel = new GameBetViewModel()
            {
                HomeTeam = "Chelsea",
                AwayTeam = "Arsenal",
                BetRate = 2,
                Prediction = "X",
                GameId = 4
            };

            gameBetViewModels = betService.AddGameBetToCollection(gameBetViewModels, updateExistingModel);

            Assert.That(gameBetViewModels.First().Prediction, Is.EqualTo("2"));
            Assert.That(gameBetViewModels.Count, Is.EqualTo(1));

            gameBetViewModels = betService.AddGameBetToCollection(gameBetViewModels, addNewModel);

            Assert.That(gameBetViewModels.Last().Prediction, Is.EqualTo("X"));
            Assert.That(gameBetViewModels.Count, Is.EqualTo(2));
        }

        [Test]
        public async Task TestCreateGameBet()
        {
            var game1 = await repo.GetByIdAsync<Game>(1);
            var game2 = await repo.GetByIdAsync<Game>(2);
            var game3 = await repo.GetByIdAsync<Game>(3);

            var model = await betService.CreateGameBet(game1.Id, "2");

            Assert.That(model, Is.Not.Null);
            Assert.That(model.Prediction, Is.EqualTo("2"));
            Assert.That(model.GameId, Is.EqualTo(game1.Id));

            model = await betService.CreateGameBet(game2.Id, "X");
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Prediction, Is.EqualTo("X"));
            Assert.That(model.GameId, Is.EqualTo(game2.Id));

            model = await betService.CreateGameBet(game3.Id, "1");
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Prediction, Is.EqualTo("1"));
            Assert.That(model.GameId, Is.EqualTo(game3.Id));
        }
    }
}
