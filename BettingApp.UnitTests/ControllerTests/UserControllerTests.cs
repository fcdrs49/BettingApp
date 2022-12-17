namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class UserControllerTests
    {
        private IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public void IndexReturnsCorrectView()
        {
            var userController = new Controllers.UserController(null, null, null, null);

            var result = userController.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task DepositReturnsCorrectView()
        {
            var currencyService = new CurrencyService(repo, new Guard());
            var userController = new Controllers.UserController(null, null, currencyService, null);

            var result = await userController.Deposit() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as DepositFormModel, Is.Not.Null);
        }
    }
}
