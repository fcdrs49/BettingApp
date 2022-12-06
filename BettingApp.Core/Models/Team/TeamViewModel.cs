using BettingApp.Core.Models.Country;
using BettingApp.Core.Models.Employee;

namespace BettingApp.Core.Models.Team
{
	public class TeamViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string? ImageUrl { get; set; }

		public string Country { get; set; } = null!;

		public IEnumerable<EmployeeViewModel> Employees { get; set; }
			= new List<EmployeeViewModel>();
	}
}
