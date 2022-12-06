using BettingApp.Core.Models.Competition;
using BettingApp.Core.Models.Team;
using BettingApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Game
{
    public class GameFormModel
    {
        public int Id { get; set; }

        [Required]
        public int CompetitionId { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        [Required]
        public int AwayTeamid { get; set; }

        [Required]
        [Display(Name = "Home Rate")]
        public decimal HomeRate { get; set; }

        [Required]
        [Display(Name = "Draw Rate")]
        public decimal DrawRate { get; set; }

        [Required]
        [Display(Name = "Away Rate")]
        public decimal AwayRate { get; set; }

        [Display(Name = "Date")]
        public DateTime DateTime { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }

        [Display(Name = "Sign")]
        public ScoreSign ScoreSign { get; set; }

        public List<CompetitionViewModel> Competitions { get; set; }
            = new List<CompetitionViewModel>();

        public List<TeamViewModel> Teams { get; set; }
            = new List<TeamViewModel>();

    }
}
