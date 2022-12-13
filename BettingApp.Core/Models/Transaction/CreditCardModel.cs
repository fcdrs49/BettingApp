using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class CreditCardModel
    {
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; } = null!;

        [Display(Name = "Expiration Month")]
        public int ExpirationMonth { get; set; }

        [Display(Name = "Expiration Year")]
        public int ExpirationYear { get; set; }
    }
}
