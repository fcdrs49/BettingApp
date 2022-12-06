using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class CompetitionConfiguration : IEntityTypeConfiguration<Competition>
    {
        public void Configure(EntityTypeBuilder<Competition> builder)
        {
            builder.HasData(CreateCompetitions());
        }

        private List<Competition> CreateCompetitions()
        {
            var competitions = new List<Competition>();

            competitions.Add(new Competition { Id = 1, CountryId = 186, Description = "First Level Of English Football", IsInternational = false, Name = "Premier League", SeasonId = 1, ImageUrl = "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png" });
            competitions.Add(new Competition { Id = 2, CountryId = 186, Description = "First Level Of English Football", IsInternational = false, Name = "Premier League", SeasonId = 2, ImageUrl = "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png" });
            competitions.Add(new Competition { Id = 3, CountryId = 186, Description = "First Level Of English Football", IsInternational = false, Name = "Premier League", SeasonId = 3, ImageUrl = "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png" });
            competitions.Add(new Competition { Id = 4, CountryId = 66, Description = "First Level Of German Football", IsInternational = false, Name = "Bundesliga", SeasonId = 1, ImageUrl = "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png" });
            competitions.Add(new Competition { Id = 5, CountryId = 66, Description = "First Level Of German Football", IsInternational = false, Name = "Bundesliga", SeasonId = 2, ImageUrl = "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png" });
            competitions.Add(new Competition { Id = 6, CountryId = 66, Description = "First Level Of German Football", IsInternational = false, Name = "Bundesliga", SeasonId = 3, ImageUrl = "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png" });
            competitions.Add(new Competition { Id = 7, CountryId = 26, Description = "First Level Of Bulgarian Football", IsInternational = false, Name = "Parva Liga", SeasonId = 1, ImageUrl = "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png" });
            competitions.Add(new Competition { Id = 8, CountryId = 26, Description = "First Level Of Bulgarian Football", IsInternational = false, Name = "Parva Liga", SeasonId = 2, ImageUrl = "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png" });
            competitions.Add(new Competition { Id = 9, CountryId = 26, Description = "First Level Of Bulgarian Football", IsInternational = false, Name = "Parva Liga", SeasonId = 3, ImageUrl = "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png" });
            competitions.Add(new Competition { Id = 10, Description = "World Cup 2022 (Qatar)", IsInternational = true, Name = "World Cup", SeasonId = 3, ImageUrl = "https://www.flashscore.com/res/image/data/hjGIig9j-KvBVDJzT.png" });

            return competitions;
        }
    }
}
