using BettingApp.Core.Models.GameBet;

namespace BettingApp.Core.Models.Bet
{
    public class BetViewModel
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public decimal WinAmount { get; set; }

        public bool Closed { get; set; }

        public DateTime DateTime { get; set; }

        public IEnumerable<GameBetViewModel> GameBets { get; set; }
            = new List<GameBetViewModel>();
    }
}
