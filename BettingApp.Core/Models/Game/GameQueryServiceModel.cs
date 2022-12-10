namespace BettingApp.Core.Models.Game
{
    public class GameQueryServiceModel
    {
        public int GamesCount { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; }
            = new List<GameViewModel>();
    }
}
