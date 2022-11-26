using BettingApp.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public TransactionType TransactionType { get; set; }

        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; } = null!;
        [ForeignKey(nameof(CurrencyCode))]
        public Currency Currency { get; set; } = null!;
    }
}
