using BettingApp.Core.Models.Country;
using BettingApp.Core.Models.Team;

namespace BettingApp.Core.Models.Employee
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public string? CountryImageUrl { get; set; }

        public int? TeamId { get; set; }

        public string? Team { get; set; }
    }
}
