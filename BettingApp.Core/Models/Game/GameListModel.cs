using System.ComponentModel.DataAnnotations;

namespace BettingApp.Core.Models.Game
{
	public class GameListModel
	{
        public int Id { get; set; }

        public string Competition { get; set; } = null!;

        [Display(Name = "Home Team")]
        public string HomeTeam { get; set; } = null!;

        [Display(Name = "Away Team")]
        public string AwayTeam { get; set; } = null!;

        [Display(Name = "Home Rate")]
        public decimal HomeRate { get; set; }

        [Display(Name = "Draw Rate")]
        public decimal DrawRate { get; set; }

        [Display(Name = "Away Rate")]
        public decimal AwayRate { get; set; }

        public DateTime Date { get; set; }
    }
}
