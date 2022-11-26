using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Currency;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Currency
    {
        [Key]
        [StringLength(ISOCodeMaxLength)]
        public string ISOCode { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal ExhangeRate { get; set; }

        public DateTime DateTime { get; set; }
    }
}
