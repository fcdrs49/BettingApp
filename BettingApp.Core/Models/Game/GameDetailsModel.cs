namespace BettingApp.Core.Models.Game
{
    public class GameDetailsModel
    {
        public GameViewModel Game { get; set; } = null!;

        public IEnumerable<GameViewModel> LastFiveHome { get; set; }
            = new List<GameViewModel>();

        public IEnumerable<GameViewModel> LastFiveAway { get; set; }
            = new List<GameViewModel>();
    }
}
