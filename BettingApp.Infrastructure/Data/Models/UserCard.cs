using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.UserCard;

namespace BettingApp.Infrastructure.Data.Models
{
    public class UserCard
    {
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [StringLength(NumberMaxLength)]
        public string CardNumber { get; set; } = null!;

        [Required]
        [StringLength(ExpirationMaxLength)]
        public string Expiration { get; set; } = null!;
    }
}
