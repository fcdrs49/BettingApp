using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.GameBet;

namespace BettingApp.Core.Contracts
{
    public interface IBetService
    {
        public Task CreateBetAsync(BetQueryModel model, string userId);
        public decimal GetBetsAmount(string userId);
        public Task<IEnumerable<BetViewModel>> GetUserBets(string userId);
        public Task<IEnumerable<GameBetViewModel>> GetGameBets(int betId);
    }
}
