namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class CurrencyControllerTests
    {
        public static IRepository repo;

        [SetUp]
        public void SetUp()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task TestCurrencyAll()
        {
            var memoryCache = MemoryCacheMock.Instance;
            var currencyServiceMock = new Mock<ICurrencyService>();
            currencyServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(new List<CurrencyModel>()
                    {
                        new CurrencyModel()
                        {
                            ISOCode = "BGN"
                        },
                        new CurrencyModel()
                        {
                            ISOCode = "EUR"
                        },
                        new CurrencyModel()
                        {
                            ISOCode = "EUR"
                        }
                    } as IEnumerable<CurrencyModel>
                ));
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);

            var result = await currencyController.All() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as List<CurrencyModel>, Is.Not.Null);
            Assert.That((result.Model as List<CurrencyModel>).Count, Is.EqualTo(3));
        }

        [Test]
        public async Task TestCurrencyAddReturnsView()
        {
            var currencyController = new CurrencyController(null, null);
            var result = currencyController.Add() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<CurrencyModel>());
        }

        [Test]
        public async Task TestAddWithErrorModel()
        {
            var currencyServiceMock = new Mock<ICurrencyService>();
            var memoryCache = MemoryCacheMock.Instance;
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);

            var model = new CurrencyModel();
            currencyController.ModelState.AddModelError("", "test");
            var result = await currencyController.Add(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task TestAddWithoutError()
        {
            var currencyServiceMock = new Mock<ICurrencyService>();
            var memoryCache = MemoryCacheMock.Instance;
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);

            var model = new CurrencyModel();
            var result = await currencyController.Add(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task TestDeleteRedirectsToAll()
        {
            var currencyServiceMock = new Mock<ICurrencyService>();
            var memoryCache = MemoryCacheMock.Instance;
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);
            var result = await currencyController.Delete("BGN") as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);

            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditWithModelError()
        {
            var currencyServiceMock = new Mock<ICurrencyService>();
            var memoryCache = MemoryCacheMock.Instance;
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);

            var model = new CurrencyModel();
            currencyController.ModelState.AddModelError("", "test");
            var result = await currencyController.Edit(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<CurrencyModel>());
        }
        [Test]
        public async Task TestEditWithoutModelError()
        {
            var currencyServiceMock = new Mock<ICurrencyService>();
            var memoryCache = MemoryCacheMock.Instance;
            var currencyController = new CurrencyController(currencyServiceMock.Object, memoryCache);

            var model = new CurrencyModel();
            var result = await currencyController.Edit(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditReturnsView()
        {
            var currencyService = new CurrencyService(repo, new Guard());
            var currencyController = new CurrencyController(currencyService, MemoryCacheMock.Instance);

            var result = await currencyController.Edit("BGN") as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }

    }
}
