using BettingApp.Core.Models.Employee;
using BettingApp.Core.Models.Game;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Team
{
	public class TeamViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		[Display(Name = "Image")]
		public string? ImageUrl { get; set; }

		public string Country { get; set; } = null!;

		public IEnumerable<EmployeeViewModel> Employees { get; set; }
			= new List<EmployeeViewModel>();

		public IEnumerable<GameViewModel> Games { get; set; }
			= new List<GameViewModel>();
	}
}
