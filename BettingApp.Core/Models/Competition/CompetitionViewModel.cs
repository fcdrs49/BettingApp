using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Competition
{
	public class CompetitionViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		[Display(Name = "Image")]
		public string? ImageUrl { get; set; }
	}
}
