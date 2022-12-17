using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.User;

namespace BettingApp.Infrastructure.Data.Models
{
    public class User : IdentityUser<string>
    {
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public IEnumerable<UserCard> Cards { get; set; }
            = new List<UserCard>();

        public IEnumerable<Bet> Bets { get; set; }
            = new List<Bet>();

        public IEnumerable<Transaction> Transactions { get; set; }
            = new List<Transaction>();
    }
}
