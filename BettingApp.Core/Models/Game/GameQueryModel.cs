using BettingApp.Core.Models.Competition;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Game
{
    public class GameQueryModel
    {
        public const int GamesPerPage = 10;

        public const int GameListPerPage = 20;

        [Display(Name = "Search by Team")]
        public string? TeamTerm { get; set; } = "";

        [Display(Name = "Search by Competition")]
        public string? Competition { get; set; } = "";

        public int CurrentPage { get; set; } = 1;

        public int TotalGamesCount { get; set; }

        public bool Upcoming { get; set; }

        public bool Results { get; set; }

        public IEnumerable<CompetitionViewModel> Competitions { get; set; }
            = new List<CompetitionViewModel>();

        public IEnumerable<GameViewModel> Games { get; set; }
            = new List<GameViewModel>();
    }
}
