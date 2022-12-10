using BettingApp.Core.Models.Country;
using System.ComponentModel.DataAnnotations;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Employee;
using static BettingApp.Infrastructure.Data.Constants.DataConstants.Common;
using BettingApp.Core.Models.Team;
using BettingApp.Infrastructure.Data.Enums;

namespace BettingApp.Core.Models.Employee
{
    public class EmployeeFormModel
    {
        public int Id { get; set; }

        [Display(Name = "Employee Type")]
        public EmployeeType EmployeeType { get; set; }

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        public IEnumerable<CountryModel> Countries { get; set; }
            = new List<CountryModel>();

        [Display(Name = "Team")]
        public int? TeamId { get; set; }

        public IEnumerable<TeamViewModel> Teams { get; set; }
            = new List<TeamViewModel>();

        [Display(Name = "Image URL")]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        public string? ImageUrl { get; set; }
    }
}
