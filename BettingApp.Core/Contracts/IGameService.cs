using BettingApp.Core.Models.Game;

namespace BettingApp.Core.Contracts
{
    public interface IGameService
    {
        public Task<IEnumerable<GameViewModel>> NextTenGames();
    }
}
