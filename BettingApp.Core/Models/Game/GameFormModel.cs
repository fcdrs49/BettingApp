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
        [Display(Name = "Competition Id")]
        public int CompetitionId { get; set; }

        [Required]
        [Display(Name = "Home Team Id")]
        public int HomeTeamId { get; set; }

        [Required]
        [Display(Name = "Away Team Id")]
        public int AwayTeamId { get; set; }

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

        [Display(Name = "Home Team Goals")]
        public int HomeTeamGoals { get; set; }

        [Display(Name = "Away Team Goals")]
        public int AwayTeamGoals { get; set; }

        [Display(Name = "Sign")]
        public ScoreSign ScoreSign { get; set; }

        public bool Finished { get; set; }

        public IEnumerable<CompetitionViewModel> Competitions { get; set; }
            = new List<CompetitionViewModel>();

        public IEnumerable<TeamViewModel> Teams { get; set; }
            = new List<TeamViewModel>();

    }
}
