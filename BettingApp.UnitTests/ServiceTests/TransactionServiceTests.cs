namespace BettingApp.UnitTests
{
    [TestFixture]
    public class TransactionServiceTests
    {
        private IRepository repo { get; set; }
        private ITransactionService transactionService { get; set; }
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
            betService = new BetService(repo, guard);
            transactionService = new TransactionService(repo, betService);
        }

        [Test]
        public async Task AddUserCard()
        {
            var userId = Guid.NewGuid().ToString();
            var creditCardModel = new CreditCardModel()
            {
                CardNumber = "342154377932282",
                ExpirationMonth = 11,
                ExpirationYear = 23
            };

            await transactionService.AddUserCard(userId, creditCardModel);
            var creditCard = await repo.AllReadonly<UserCard>()
                .Where(c => c.CardNumber == creditCardModel.CardNumber)
                .FirstOrDefaultAsync();

            Assert.That(creditCard, Is.Not.Null);
            Assert.That(creditCard.ExpirationMonth, Is.EqualTo(11));
            Assert.That(creditCard.ExpirationYear, Is.EqualTo(23));

            Assert.That(await transactionService.UserCardExists(userId, creditCard.CardNumber), Is.True);
        }

        [Test]
        public async Task DepositWithdrawAsync()
        {
            var user = await repo.AllReadonly<User>().FirstOrDefaultAsync();

            var model = new DepositFormModel()
            {
                Amount = 100,
                CardNumber = "342154377932282",
                CurrencyCode = "BGN",
                CVC = 222,
                ExpirationMonth = 12,
                ExpirationYear = 24,
                FirstName = "test",
                LastName = "test2"
            };

            await transactionService.DepositAsync(model, user.Id);

            var deposit = await repo.AllReadonly<Transaction>()
                .Where(t => t.CardNumber == model.CardNumber &&
                    t.Amount == model.Amount)
                .FirstOrDefaultAsync();

            Assert.That(deposit, Is.Not.Null);
            var transactions = await transactionService.ByUserAsync(user.Id);
            Assert.That(transactions.Count(), Is.GreaterThan(0));

            var totalAmount = transactionService.TotalAmount(user.Id);
            Assert.That(totalAmount, Is.EqualTo(100));

            var withdrawModel = new WithdrawFormModel()
            {
                Amount = 200,
                CreditCard = model.CardNumber
            };
            Assert.ThrowsAsync<InvalidOperationException>(async () =>
                await transactionService.WithdrawAsync(withdrawModel, user.Id));

            withdrawModel.Amount = 50;
            await transactionService.WithdrawAsync(withdrawModel, user.Id);
            totalAmount = transactionService.TotalAmount(user.Id);
            Assert.That(totalAmount, Is.EqualTo(50));
        }

        [Test]
        public async Task ByUserAsync()
        {
            var transactions = await transactionService.ByUserAsync("random");

            Assert.That(transactions.Count(), Is.LessThan(1));
        }

        [Test]
        public async Task GetUserCards()
        {
            var userId = Guid.NewGuid().ToString();
            var cards = await transactionService.GetUserCards(userId);
            Assert.That(cards.Count(), Is.EqualTo(0));

            await repo.AddAsync(new UserCard()
            {
                CardNumber = "342154377932282",
                ExpirationMonth = 11,
                ExpirationYear = 2025,
                UserId = userId
            });
            await repo.SaveChangesAsync();

            cards = await transactionService.GetUserCards(userId);
            Assert.That(cards.Count(), Is.EqualTo(1));
        }
    }
}
