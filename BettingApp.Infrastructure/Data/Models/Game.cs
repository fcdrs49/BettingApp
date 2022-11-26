using BettingApp.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BettingApp.Infrastructure.Data.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CompetitionId { get; set; }
        [ForeignKey(nameof(CompetitionId))]
        public Competition Competition { get; set; } = null!;

        [Required]
        public int HomeTeamId { get; set; }
        [ForeignKey(nameof(HomeTeamId))]
        public Team HomeTeam { get; set; } = null!;

        [Required]
        public int AwayTeamId { get; set; }
        [ForeignKey(nameof(AwayTeamId))]
        public Team AwayTeam { get; set; } = null!;

        [Precision(18,2)]
        public decimal HomeRate { get; set; }

        [Precision(18, 2)]
        public decimal DrawRate { get; set; }

        [Precision(18, 2)]
        public decimal AwayRate { get; set; }

        public DateTime DateTime { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }

        public ScoreSign Sign { get; set; }

        public bool Finished { get; set; }

        public IEnumerable<GameBet> GameBets { get; set; }
            = new List<GameBet>();
    }
}
