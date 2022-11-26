using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Country;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Competition> Competitions { get; set; }
            = new List<Competition>();

        public IEnumerable<Employee> Employees { get; set; }
            = new List<Employee>();

        public IEnumerable<Team> Teams { get; set; }
            = new List<Team>();
    }
}
