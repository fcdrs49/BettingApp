using BettingApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Employee;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Common;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public EmployeeType EmployeeType { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [StringLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        public int CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public int? TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public Team? Team { get; set; }
    }
}
