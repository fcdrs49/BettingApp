using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Competition;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [StringLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        public bool IsInternational { get; set; }

        public int? CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; }

        [Required]
        public int SeasonId { get; set; }
        [ForeignKey(nameof(SeasonId))]
        public Season Season { get; set; } = null!;

        public IEnumerable<Game> Games { get; set; }
            = new List<Game>();
    }
}