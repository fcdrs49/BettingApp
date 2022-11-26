using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Team;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public bool IsInternational { get; set; }

        [Required]
        public int CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public List<Employee> Employees { get; set; }
            = new List<Employee>();

        public IEnumerable<Game> HomeGames { get; set; }
            = new List<Game>();

        public IEnumerable<Game> AwayGames { get; set; }
            = new List<Game>();
    }
}
