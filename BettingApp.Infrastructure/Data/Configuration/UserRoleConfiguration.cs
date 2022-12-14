using BettingApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(AssingRolesToUsers());
        }

        private List<IdentityUserRole<string>> AssingRolesToUsers()
        {
            var adminUserGuid = "ed4684b3-22a8-42d5-8fb4-b9a31a93b288";
            var adminRoleGuid = "41adc285-9e99-4e3d-ada3-41b53899e5df";
            var bookmakerUserGuid = "63013373-f53e-4ddc-8f4d-3058ef0c115a";
            var bookmakerRoleGuid = "a4d7cb18-0e81-45d4-8dca-b1da6bdd0184";

            var userRoles = new List<IdentityUserRole<string>>();
            var adminUserRole = new IdentityUserRole<string>
            {
                UserId = adminUserGuid,
                RoleId = adminRoleGuid
            };
            userRoles.Add(adminUserRole);

            var bookmakerUserRole = new IdentityUserRole<string>
            {
                UserId = bookmakerUserGuid,
                RoleId = bookmakerRoleGuid
            };
            userRoles.Add(bookmakerUserRole);

            return userRoles;
        }
    }
}
