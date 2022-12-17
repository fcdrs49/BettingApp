namespace BettingApp.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private IRepository repo { get; set; }
        private IUserService userService { get; set; }
        private ITransactionService transactionService { get; set; }
        private IBetService betService { get; set; }
        private IGuard guard { get; set; }

        [SetUp]
        public void SetUp()
        {
            repo = DatabaseMock.Instance;
            betService = new BetService(repo, guard);
            transactionService = new TransactionService(repo, betService);
            userService = new UserService(transactionService, betService, repo);
        }

        [Test]
        public async Task AllBalance()
        {
            var users = await repo.AllReadonly<User>().ToListAsync();
            repo.DeleteRange(users);
            await repo.SaveChangesAsync();
            var userModels = await userService.All();
            Assert.That(userModels.Count(), Is.EqualTo(0));

            var hasher = new PasswordHasher<User>();

            var adminUser = new User()
            {
                Id = "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                UserName = "admin@bettingapp.bg",
                NormalizedUserName = "ADMIN@BETTINGAPP.BG",
                Email = "admin@bettingapp.bg",
                NormalizedEmail = "ADMIN@BETTINGAPP.BG",
                FirstName = "admin",
                LastName = "admin",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash =
                hasher.HashPassword(adminUser, "AdminPass432");
            await repo.AddAsync(adminUser);

            var bookmakerUser = new User()
            {
                Id = "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                UserName = "bookmaker@bettingapp.bg",
                NormalizedUserName = "BOOKMAKER@BETTINGAPP.BG",
                Email = "bookmaker@bettingapp.bg",
                NormalizedEmail = "BOOKMAKER@BETTINGAPP.BG",
                FirstName = "Ivan",
                LastName = "Ivanov",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            bookmakerUser.PasswordHash =
                hasher.HashPassword(bookmakerUser, "BookmakerPass222");
            await repo.AddAsync(bookmakerUser);
            await repo.SaveChangesAsync();

            userModels = await userService.All();
            Assert.Multiple(() =>
            {
                Assert.That(userModels.Count, Is.EqualTo(2));
                Assert.That(userModels.Any(u => u.EMail == adminUser.Email), Is.True);
                Assert.That(userModels.Any(u => u.FullName == bookmakerUser.FirstName + " " + bookmakerUser.LastName), Is.True);
            });

            var deposit = new DepositFormModel()
            {
                Amount = 150,
                CardNumber = "4532846028022502",
                CurrencyCode = "BGN",
                ExpirationMonth = 12,
                ExpirationYear = 2025,
                CVC = 123,
                FirstName = "Admin",
                LastName = "User"
            };
            await transactionService.DepositAsync(deposit, adminUser.Id);

            var balance = userService.GetBalance(adminUser.Id);
            Assert.That(balance, Is.EqualTo(deposit.Amount));
        }
    }
}
