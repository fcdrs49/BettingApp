namespace BettingApp.UnitTests
{
    [TestFixture]
    public class BetServiceTests
    {
        private IRepository repo { get; set; }
        private IGuard guard { get; set; }
        private IBetService betService { get; set; }
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
        }

        [Test]
        public async Task TestCreateBetAsync()
        {
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo);

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
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo);
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
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo);
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
            var loggerMock = new Mock<ILogger<BetService>>();
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo);
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
    }
}
