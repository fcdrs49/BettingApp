using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.GameBet
{
    public class GameBetViewModel
    {
        public int GameId { get; set; }

        [Display(Name = "Home Team")]
        public string HomeTeam { get; set; } = null!;

        [Display(Name = "Away Team")]
        public string AwayTeam { get; set; } = null!;

        public string Prediction { get; set; } = null!;

        [Display(Name = "Bet Rate")]
        public decimal BetRate { get; set; }

        public string? Won { get; set; }
    }
}
