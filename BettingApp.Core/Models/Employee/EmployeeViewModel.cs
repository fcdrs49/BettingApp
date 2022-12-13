using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Employee
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        public string Country { get; set; } = null!;

        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Image")]
        public string? CountryImageUrl { get; set; }

        [Display(Name = "Team Id")]
        public int? TeamId { get; set; }

        public string? Team { get; set; }

        public string Position { get; set; } = null!;
    }
}
