using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Currency;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Currency
    {
        [Key]
        [StringLength(ISOCodeLength)]
        public string ISOCode { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [Precision(18,2)]
        public decimal ExchangeRate { get; set; }

        public DateTime DateTime { get; set; }
    }
}
