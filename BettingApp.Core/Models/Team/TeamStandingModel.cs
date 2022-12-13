using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Team
{
    public class TeamStandingModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Matches { get; set; }

        [Display(Name = "W")]
        public int Wins { get; set; }

        [Display(Name = "D")]
        public int Draws { get; set; }

        [Display(Name = "L")]
        public int Losses { get; set; }

        [Display(Name = "GF")]
        public int GoalsFor { get; set; }

        [Display(Name = "GA")]
        public int GoalsAgainst { get; set; }

        public int Points { get; set; }

        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }
    }
}
