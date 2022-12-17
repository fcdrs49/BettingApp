namespace BettingApp.UnitTests.ControllerTests
{
    [TestFixture]
    public class CountryControllerTests
    {
        public static IRepository repo;

        [SetUp]
        public void SetUp()
        {
            repo = DatabaseMock.Instance;
        }

        [Test]
        public async Task TestCountryAll()
        {
            var memoryCache = MemoryCacheMock.Instance;
            var countryServiceMock = new Mock<ICountryService>();
            countryServiceMock
                .Setup(c => c.AllAsync())
                .Returns(
                    Task.FromResult(new List<CountryModel>()
                    {
                        new CountryModel()
                        {
                            Id = 1,
                            Name = "Bulgaria"
                        },
                        new CountryModel()
                        {
                            Id = 2,
                            Name = "Germany"
                        }
                    } as IEnumerable<CountryModel>
                ));
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);

            var result = await countryController.All() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model as List<CountryModel>, Is.Not.Null);
            Assert.That((result.Model as List<CountryModel>).Count, Is.EqualTo(2));
        }

        [Test]
        public void TestCountryAddReturnsView()
        {
            var countryController = new CountryController(null, null);
            var result = countryController.Add() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<CountryModel>());
        }

        [Test]
        public async Task TestAddWithErrorModel()
        {
            var countryServiceMock = new Mock<ICountryService>();
            var memoryCache = MemoryCacheMock.Instance;
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);

            var model = new CountryModel();
            countryController.ModelState.AddModelError("", "test");
            var result = await countryController.Add(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }

        [Test]
        public async Task TestAddWithoutError()
        {
            var countryServiceMock = new Mock<ICountryService>();
            var memoryCache = MemoryCacheMock.Instance;
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);

            var model = new CountryModel();
            var result = await countryController.Add(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestDeleteRedirectsToAll()
        {
            var countryServiceMock = new Mock<ICountryService>();
            var memoryCache = MemoryCacheMock.Instance;
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);
            var result = await countryController.Delete(1) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditWithModelError()
        {
            var countryServiceMock = new Mock<ICountryService>();
            var memoryCache = MemoryCacheMock.Instance;
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);

            var model = new CountryModel();
            countryController.ModelState.AddModelError("", "test");
            var result = await countryController.Edit(model) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.TypeOf<CountryModel>());
        }
        [Test]
        public async Task TestEditWithoutModelError()
        {
            var countryServiceMock = new Mock<ICountryService>();
            var memoryCache = MemoryCacheMock.Instance;
            var countryController = new CountryController(countryServiceMock.Object, memoryCache);

            var model = new CountryModel();
            var result = await countryController.Edit(model) as RedirectToActionResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ActionName, Is.EqualTo("All"));
        }

        [Test]
        public async Task TestEditReturnsView()
        {
            var countryService = new CountryService(repo, new Guard());
            var countryController = new CountryController(countryService, MemoryCacheMock.Instance);

            var result = await countryController.Edit(1) as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Not.Null);
        }
    }
}
