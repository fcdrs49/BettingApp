using BettingApp.Core.Models.GameBet;
using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Bet
{
    public class BetQueryModel
    {
        [Required]
        [Range(0.5,10000)]
        public decimal Amount { get; set; }

        public List<GameBetViewModel> GameBets { get; set; }
            = new List<GameBetViewModel>();
    }
}
