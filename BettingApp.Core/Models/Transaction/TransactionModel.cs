using BettingApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class TransactionModel
    {
        [Display(Name = "Transaction Type")]
        public string TransactionType { get; set; } = null!;

        public decimal Amount { get; set; }

        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; } = null!;

        [Display(Name = "Date")]
        public DateTime DateTime { get; set; }
    }
}
