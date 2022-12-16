﻿using BettingApp.Core.Models.Currency;
using BettingApp.Core.Models.Employee;

namespace BettingApp.UnitTests
{
    [TestFixture]
    public class CurrencyServiceTests
    {
        private IRepository repo { get; set; }
        private ICurrencyService currencyService { get; set; }
        private BettingAppDbContext bettingAppDbContext { get; set; }

        [SetUp]
        public void SetUp()
        {
            var contextOptions = new DbContextOptionsBuilder<BettingAppDbContext>()
                .UseInMemoryDatabase("BetDb")
                .Options;

            bettingAppDbContext = new BettingAppDbContext(contextOptions);

            bettingAppDbContext.Database.EnsureDeleted();
            bettingAppDbContext.Database.EnsureCreated();
            repo = new Repository(bettingAppDbContext);
            currencyService = new CurrencyService(repo);
        }

        [Test]
        public async Task TestCRUD()
        {
            var currencies = repo.AllReadonly<Currency>();
            repo.DeleteRange(currencies);
            await repo.SaveChangesAsync();

            var currencyModels = await currencyService.AllAsync();
            Assert.That(currencyModels.Count(), Is.EqualTo(0));

            var bgnModel = new CurrencyModel()
            {
                ISOCode = "BGN",
                Description = "български лев",
                DateTime = DateTime.Now,
                ExchangeRate = 1.95m,
                ShortDescription = "лв."
            };
            await currencyService.CreateAsync(bgnModel);
            currencyModels = await currencyService.AllAsync();
            Assert.That(currencyModels.Count(), Is.EqualTo(1));

            var currency = await currencyService.ByCodeAsync(bgnModel.ISOCode);
            Assert.Multiple(() =>
            {
                Assert.That(currency.ISOCode, Is.EqualTo(bgnModel.ISOCode));
                Assert.That(currency.Description, Is.EqualTo(bgnModel.Description));
                Assert.That(currency.ExchangeRate, Is.EqualTo(bgnModel.ExchangeRate));
            });
            currency.Description = "бълг.лев";
            await currencyService.EditAsync(currency);
            var currencyTest = await currencyService.ByCodeAsync(bgnModel.ISOCode);
            Assert.Multiple(() =>
            {
                Assert.That(currencyTest.ISOCode, Is.EqualTo(currency.ISOCode));
                Assert.That(currencyTest.Description, Is.EqualTo(currency.Description));
            });
            await currencyService.DeleteAsync(currency.ISOCode);
            currencyModels = await currencyService.AllAsync();
            Assert.That(currencyModels.Count(), Is.EqualTo(0));
        }
    }
}