using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; } = null!;
        [ForeignKey(nameof(CurrencyCode))]
        public Currency Currency { get; set; } = null!;

        public bool Won { get; set; }

        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal WinAmount { get; set; }

        public bool Closed { get; set; }

        public bool Cancelled { get; set; }

        public DateTime DateTime { get; set; }

        public IEnumerable<GameBet> GameBets { get; set; }
            = new List<GameBet>();

    }
}
