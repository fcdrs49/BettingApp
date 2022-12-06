using BettingApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class TransactionModel
    {
        public int Id { get; set; }

        public string User { get; set; } = null!;

        [Display(Name = "Transaction Type")]
        public TransactionType TransactionType { get; set; }

        public decimal Amount { get; set; }

        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; } = null!;
    }
}
