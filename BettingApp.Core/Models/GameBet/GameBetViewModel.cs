namespace BettingApp.Core.Models.GameBet
{
    public class GameBetViewModel
    {
        public int GameId { get; set; }

        public string HomeTeam { get; set; } = null!;

        public string AwayTeam { get; set; } = null!;

        public string Prediction { get; set; } = null!;

        public decimal BetRate { get; set; }

        public bool Won { get; set; }
    }
}
