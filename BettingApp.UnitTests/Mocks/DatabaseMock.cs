using BettingApp.Infrastructure.Data;

namespace BettingApp.UnitTests.Mocks
{
    public static class DatabaseMock
    {
        public static IRepository Instance
        {
            get
            {
                var contextOptions = new DbContextOptionsBuilder<BettingAppDbContext>()
                    .UseInMemoryDatabase("BetDb")
                .Options;

                var bettingAppDbContext = new BettingAppDbContext(contextOptions);

                bettingAppDbContext.Database.EnsureDeleted();
                bettingAppDbContext.Database.EnsureCreated();
                return new Repository(bettingAppDbContext);
            }
        }
    }
}
