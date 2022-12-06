using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Currency;

namespace BettingApp.Core.Models.Currency
{
    public class CurrencyModel
    {
        [Required]
        [StringLength(ISOCodeLength, MinimumLength = ISOCodeLength)]
        public string ISOCode { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ShortDescriptionMaxLength, MinimumLength = ShortDescriptionMinLength)]
        public string ShortDescription { get; set; } = null!;

        [Required]
        public decimal ExchangeRate { get; set; }

        public DateTime DateTime { get; set; }
    }
}
