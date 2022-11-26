using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Season;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Season
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CodeMaxLength)]
        public string Code { get; set; } = null!;

        public IEnumerable<Competition> Competitions { get; set; }
            = new List<Competition>();
    }
}
