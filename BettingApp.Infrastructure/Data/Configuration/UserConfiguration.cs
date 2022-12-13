using BettingApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var adminUser = new User()
            {
                Id = "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                UserName = "admin@bettingapp.bg",
                NormalizedUserName = "ADMIN@BETTINGAPP.BG",
                Email = "admin@bettingapp.bg",
                NormalizedEmail = "ADMIN@BETTINGAPP.BG",
                FirstName = "admin",
                LastName = "admin",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash =
                hasher.HashPassword(adminUser, "AdminPass432");
            users.Add(adminUser);

            var bookmakerUser = new User()
            {
                Id = "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                UserName = "bookmaker@bettingapp.bg",
                NormalizedUserName = "BOOKMAKER@BETTINGAPP.BG",
                Email = "bookmaker@bettingapp.bg",
                NormalizedEmail = "BOOKMAKER@BETTINGAPP.BG",
                FirstName = "Ivan",
                LastName = "Ivanov",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            bookmakerUser.PasswordHash = 
                hasher.HashPassword(bookmakerUser, "BookmakerPass222");
            users.Add(bookmakerUser);

            var user = new User()
            {
                Id = "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                UserName = "user2@bettingapp.bg",
                NormalizedEmail = "user2@bettingapp.bg",
                Email = "user2@bettingapp.bg",
                NormalizedUserName = "user2@bettingapp.bg",
                FirstName = "Petar",
                LastName = "Petrov"
            };
            user.PasswordHash
                = hasher.HashPassword(user, "UserPass321");
            users.Add(user);

            return users;
        }
    }
}