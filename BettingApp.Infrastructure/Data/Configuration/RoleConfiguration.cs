using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            var roles = new List<IdentityRole>();

            var adminRole = new IdentityRole
            {
                Id = "41adc285-9e99-4e3d-ada3-41b53899e5df",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            };
            roles.Add(adminRole);

            var bookmakerRole = new IdentityRole
            {
                Id = "a4d7cb18-0e81-45d4-8dca-b1da6bdd0184",
                Name = "Bookmaker",
                NormalizedName = "BOOKMAKER"
            };
            roles.Add(bookmakerRole);

            return roles;
        }
    }
}
