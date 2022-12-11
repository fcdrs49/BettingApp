using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class DepositFormModel
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        [CreditCard]
        public string CardNumber { get; set; } = null!;

        [Required]
        [Range(100, 999)]
        public int CVC { get; set; }

        [Required]
        [Range(1, 12)]
        public int ExpirationMonth { get; set; }

        [Required]
        [Range(2022, 2040)]
        public int ExpirationYear { get; set; }

        [Required]
        [Range(30, 10000)]
        public int Amount { get; set; }

        [Required]
        public string CurrencyCode { get; set; } = null!;

        public IEnumerable<string> Currencies { get; set; }
            = new List<string>();
    }
}
