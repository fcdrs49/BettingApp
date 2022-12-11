using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Transaction
{
    public class WithdrawFormModel
    {
        [Range(0, 10000)]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CreditCard { get; set; } = null!;

        public IEnumerable<string> CreditCards { get; set; }
            = new List<string>();
    }
}
