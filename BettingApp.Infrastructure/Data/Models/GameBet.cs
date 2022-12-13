using BettingApp.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BettingApp.Infrastructure.Data.Models
{
    public class GameBet
    {
        [Key]
        public int BetId { get; set; }
        [ForeignKey(nameof(BetId))]
        public Bet Bet { get; set; } = null!;

        [Key]
        public int GameId { get; set; }
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; } = null!;

        [Precision(18,2)]
        public decimal BetRate { get; set; }

        public ScoreSign Prediction { get; set; }

        public bool Won { get; set; }
    }
}
