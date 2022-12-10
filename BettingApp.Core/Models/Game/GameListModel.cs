namespace BettingApp.Core.Models.Game
{
	public class GameListModel
	{
        public int Id { get; set; }

        public string Competition { get; set; } = null!;

        public string HomeTeam { get; set; } = null!;

        public string AwayTeam { get; set; } = null!;

        public decimal HomeRate { get; set; }

        public decimal DrawRate { get; set; }

        public decimal AwayRate { get; set; }

        public DateTime Date { get; set; }
    }
}
