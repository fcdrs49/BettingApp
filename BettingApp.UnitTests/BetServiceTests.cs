using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Models.GameBet;
using BettingApp.Core.Services;
using BettingApp.Infrastructure.Data;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Enums;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace BettingApp.UnitTests
{
    [TestFixture]
    public class BetServiceTests
    {
        private IRepository repo { get; set; }
        private ILogger<BetService> logger { get; set; }
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
            var loggerMock = new Mock<ILogger<BetService>>();
            logger = loggerMock.Object;
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo, bettingAppDbContext, logger);

            List<GameBetViewModel> gameBetModels = new List<GameBetViewModel>();
            gameBetModels.Add(new GameBetViewModel()
            {
                GameId = 1,
                BetRate = 2.5m,
                Prediction = "1"
            });
            gameBetModels.Add(new GameBetViewModel()
            {
                GameId = 2,
                BetRate = 2,
                Prediction = "X"
            });

            await betService.CreateBetAsync(new Core.Models.Bet.BetQueryModel()
            {
                Amount = 10,
                GameBets = gameBetModels
            }, "c8ff8bd9-e302-488e-a71e-58418f19ded9");

            var bet = await repo.GetByIdAsync<Bet>(1);
            var gameBets = await repo.AllReadonly<GameBet>()
                .Where(gb => gb.BetId == 1)
                .ToListAsync();

            Assert.That(2, Is.EqualTo(gameBets.Count));
            Assert.That(10, Is.EqualTo(bet.Amount));
        }

        [Test]
        public async Task TestGetBetsAmount()
        {
            var loggerMock = new Mock<ILogger<BetService>>();
            logger = loggerMock.Object;
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo, bettingAppDbContext, logger);
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

            Assert.That(40, Is.EqualTo(betsAmount));
        }

        [Test]
        public async Task TestGetUserBets()
        {
            var loggerMock = new Mock<ILogger<BetService>>();
            logger = loggerMock.Object;
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo, bettingAppDbContext, logger);
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

            Assert.That(1, Is.EqualTo(bets.Count()));
            Assert.That(2, Is.EqualTo(bets.FirstOrDefault()?.GamesCount));
            Assert.That(5, Is.EqualTo(bets.FirstOrDefault()?.BetRate));
        }

        [Test]
        public async Task TestGetGameBets()
        {
            var loggerMock = new Mock<ILogger<BetService>>();
            logger = loggerMock.Object;
            var repo = new Repository(bettingAppDbContext);
            betService = new BetService(repo, bettingAppDbContext, logger);
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

            Assert.That(2, Is.EqualTo(gameBets.Count()));
            Assert.That("Arsenal", Is.EqualTo(gameBets.FirstOrDefault()?.HomeTeam));
            Assert.That("Chelsea", Is.EqualTo(gameBets.LastOrDefault()?.AwayTeam));
        }
    }
}
