using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Team;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Common;
using BettingApp.Core.Models.Country;

namespace BettingApp.Core.Models.Team
{
    public class TeamFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Display(Name = "International")]
        public bool IsInternational { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Image")]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string? ImageUrl { get; set; }

        public IEnumerable<CountryModel> Countries { get; set; }
            = new List<CountryModel>();
    }
}
