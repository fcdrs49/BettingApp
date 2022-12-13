using BettingApp.Core.Models.Competition;
using BettingApp.Core.Models.Team;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Game
{
    public class GameViewModel
    {
        public int Id { get; set; }

        public CompetitionViewModel Competition { get; set; } = null!;

        [Display(Name = "Home Team")]
        public TeamViewModel HomeTeam { get; set; } = null!;

        [Display(Name = "Away Team")]
        public TeamViewModel AwayTeam { get; set; } = null!;

        [Display(Name = "Home Rate")]
        public decimal HomeRate { get; set; }

        [Display(Name = "Draw Rate")]
        public decimal DrawRate { get; set; }

        [Display(Name = "Away Rate")]
        public decimal AwayRate { get; set; }

        [Display(Name = "Home Team Goals")]
        public int HomeGoals { get; set; }

        [Display(Name = "Away Team Goals")]
        public int AwayGoals { get; set; }

        public DateTime Date { get; set; }
    }
}
