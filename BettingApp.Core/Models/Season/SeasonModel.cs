using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Season;

namespace BettingApp.Core.Models.Season
{
    public class SeasonModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(CodeMaxLength, MinimumLength = CodeMinLength)]
        public string Code { get; set; } = null!;
    }
}
