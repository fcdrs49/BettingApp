using BettingApp.Core.Models.Team;

namespace BettingApp.Core.Models.Competition
{
    public class StandingViewModel
    {
        public string Competition { get; set; } = null!;

        public int CompetitionId { get; set; }

        public List<TeamStandingModel> Teams
            = new List<TeamStandingModel>();

        public IEnumerable<CompetitionViewModel> Competitions
            = new List<CompetitionViewModel>();
    }
}
