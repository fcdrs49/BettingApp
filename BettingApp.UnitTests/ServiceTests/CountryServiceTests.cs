namespace BettingApp.UnitTests
{
    [TestFixture]
    public class CountryServiceTests
    {
        private IRepository repo { get; set; }
        private ICountryService countryService { get; set; }
        private IGuard guard { get; set; }
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
            guard = new Guard();
            countryService = new CountryService(repo, guard);
        }

        [Test]
        public async Task TestCRUD()
        {
            var oldCountriesCount = repo.AllReadonly<Country>().Count();

            var countryModel = new CountryModel()
            {
                Name = "test"
            };

            await countryService.CreateAsync(countryModel);
            await repo.SaveChangesAsync();

            var newCountriesCount = repo.AllReadonly<Country>().Count();

            Assert.That(newCountriesCount, Is.EqualTo(oldCountriesCount+1));

            var country = await repo.AllReadonly<Country>().LastAsync();

            Assert.Multiple(() => {
                Assert.That(country, Is.Not.Null);
                Assert.That(country.Name, Is.EqualTo(countryModel.Name));
            });

            countryModel = await countryService.ByIdAsync(country.Id);
            Assert.Multiple(() =>
            {
                Assert.That(countryModel.Id, Is.EqualTo(country.Id));
                Assert.That(countryModel.Name, Is.EqualTo(country.Name));
            });
            countryModel.Id = country.Id;
            countryModel.Name = "testupdated";
            await countryService.EditAsync(countryModel);
            country = await repo.AllReadonly<Country>().LastAsync();


            Assert.Multiple(() => {
                Assert.That(country, Is.Not.Null);
                Assert.That(country.Name, Is.EqualTo(countryModel.Name));
            });

            var competition = new Competition()
            {
                CountryId = countryModel.Id,
                Description = "test",
                Name = "testCompetition"
            };
            await repo.AddAsync(competition);

            var team = new Team()
            {
                CountryId = countryModel.Id,
                Name = "testTeam"
            };
            await repo.AddAsync(team);
            await repo.SaveChangesAsync();

            var employee = new Employee()
            {
                CountryId = countryModel.Id,
                FirstName = "employeeFN",
                LastName = "employeeLN",
                BirthDate = DateTime.Now.AddYears(-22),
                EmployeeType = EmployeeType.Player,
                TeamId = team.Id
            };
            await repo.AddAsync(employee);
            await repo.SaveChangesAsync();

            Assert.ThrowsAsync<InvalidOperationException>(async () => await countryService.DeleteAsync(countryModel.Id), "Employees for this country exist!");
            await repo.DeleteAsync<Employee>(employee.Id);
            await repo.SaveChangesAsync();
            Assert.ThrowsAsync<InvalidOperationException>(async () => await countryService.DeleteAsync(countryModel.Id), "Competitions for this country exist!");
            await repo.DeleteAsync<Competition>(competition.Id);
            await repo.SaveChangesAsync();
            Assert.ThrowsAsync<InvalidOperationException>(async () => await countryService.DeleteAsync(countryModel.Id), "Teams for this country exist!");
            await repo.DeleteAsync<Team>(team.Id);
            await repo.SaveChangesAsync();

            await countryService.DeleteAsync(countryModel.Id);
            newCountriesCount = await repo.AllReadonly<Country>().CountAsync();

            Assert.That(newCountriesCount, Is.EqualTo(oldCountriesCount));
        }
    }

}
