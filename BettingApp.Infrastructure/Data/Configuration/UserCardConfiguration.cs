using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class UserCardConfiguration : IEntityTypeConfiguration<UserCard>
    {
        public void Configure(EntityTypeBuilder<UserCard> builder)
        {
            builder.HasData(CreateUserCard());
        }

        private List<UserCard> CreateUserCard()
        {
            var userCards = new List<UserCard>();

            userCards.Add(new UserCard() { UserId = "63013373-f53e-4ddc-8f4d-3058ef0c115a", CardNumber = "5285491935520086", ExpirationMonth = 11, ExpirationYear = 23 });
            userCards.Add(new UserCard() { UserId = "63013373-f53e-4ddc-8f4d-3058ef0c115a", CardNumber = "5556300572039742", ExpirationMonth = 5, ExpirationYear = 24 });
            userCards.Add(new UserCard() { UserId = "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5", CardNumber = "5213192405606424", ExpirationMonth = 12, ExpirationYear = 22 });

            return userCards;
        }
    }
}
