using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Currency;

namespace BettingApp.Core.Models.Currency
{
    public class CurrencyModel
    {
        [Required]
        [StringLength(ISOCodeLength, MinimumLength = ISOCodeLength)]
        [Display(Name = "Currency Code")]
        public string ISOCode { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ShortDescriptionMaxLength, MinimumLength = ShortDescriptionMinLength)]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [Display(Name = "Exchange Rate")]
        public decimal ExchangeRate { get; set; }

        [Display(Name = "Date")]
        public DateTime DateTime { get; set; }
    }
}
