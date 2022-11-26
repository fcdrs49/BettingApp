using Microsoft.AspNetCore.Identity;

namespace BettingApp.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<UserCard> Cards { get; set; }
            = new List<UserCard>();

        public IEnumerable<Bet> Bets { get; set; }
            = new List<Bet>();

        public IEnumerable<Transaction> Transactions { get; set; }
            = new List<Transaction>();
    }
}
