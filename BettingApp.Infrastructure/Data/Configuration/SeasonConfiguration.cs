using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasData(CreateSeasons());
        }

        private List<Season> CreateSeasons()
        {
            var seasons = new List<Season>();

            seasons.Add(new Season() { Id = 1, Code = "2020" });
            seasons.Add(new Season() { Id = 2, Code = "2021" });
            seasons.Add(new Season() { Id = 3, Code = "2022" });

            return seasons;
        }
    }
}
