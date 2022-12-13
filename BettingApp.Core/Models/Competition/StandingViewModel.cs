using BettingApp.Core.Models.Team;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Competition
{
    public class StandingViewModel
    {
        public string Competition { get; set; } = null!;

        [Display(Name = "Id")]
        public int CompetitionId { get; set; }

        public List<TeamStandingModel> Teams
            = new List<TeamStandingModel>();

        public IEnumerable<CompetitionViewModel> Competitions
            = new List<CompetitionViewModel>();
    }
}
