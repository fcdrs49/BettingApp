using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class DepositFormModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [CreditCard]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = null!;

        [Required]
        [Range(100, 999)]
        public int CVC { get; set; }

        [Required]
        [Range(1, 12)]
        [Display(Name = "Expiration Month")]
        public int ExpirationMonth { get; set; }

        [Required]
        [Range(2022, 2040)]
        [Display(Name = "Expiration Year")]
        public int ExpirationYear { get; set; }

        [Required]
        [Range(30, 10000)]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; } = null!;

        public IEnumerable<string> Currencies { get; set; }
            = new List<string>();
    }
}
