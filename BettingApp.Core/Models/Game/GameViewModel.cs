using BettingApp.Core.Models.Competition;
using BettingApp.Core.Models.Team;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Game
{
    public class GameViewModel
    {
        public int Id { get; set; }

        public CompetitionViewModel Competition { get; set; } = null!;

        public TeamViewModel HomeTeam { get; set; } = null!;

        public TeamViewModel AwayTeam { get; set; } = null!;

        public decimal HomeRate { get; set; }

        public decimal DrawRate { get; set; }

        public decimal AwayRate { get; set; }

        public string Date { get; set; } = null!;
    }
}
