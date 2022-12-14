using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Bet
{
    public class BetViewModel
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; } = null!;

        [Display(Name = "Win Amount")]
        public decimal WinAmount { get; set; }

        public bool Closed { get; set; }

        [Display(Name = "Date")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Bet Rate")]
        public decimal BetRate { get; set; }

        [Display(Name = "Games Count")]
        public int GamesCount { get; set; }

        public string Won { get; set; } = null!;

        public bool CanBeClosed { get; set; }
    }
}
