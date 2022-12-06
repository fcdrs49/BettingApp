using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Common;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Country;

namespace BettingApp.Core.Models.Country
{
    public class CountryModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string? ImageUrl { get; set; }
    }
}
