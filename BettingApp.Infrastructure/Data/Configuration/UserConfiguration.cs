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

            var user = new User()
            {
                Id = "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                UserName = "admin",
                Email = "admin@bettingapp.bg",
                FirstName = "admin",
                LastName = "admin"
            };
            user.PasswordHash =
                hasher.HashPassword(user, "Init123$");
            users.Add(user);

            user = new User()
            {
                Id = "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                UserName = "user1",
                Email = "user1@bettingapp.bg",
                FirstName = "Ivan",
                LastName = "Ivanov"
            };
            user.PasswordHash = 
                hasher.HashPassword(user, "Pass123!");
            users.Add(user);

            user = new User()
            {
                Id = "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                UserName = "user2",
                Email = "user2@bettingapp.bg",
                FirstName = "Petar",
                LastName = "Petrov"
            };
            user.PasswordHash
                = hasher.HashPassword(user, "Password321?");
            users.Add(user);

            return users;
        }
    }
}