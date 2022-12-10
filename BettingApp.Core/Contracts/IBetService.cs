using BettingApp.Core.Models.Bet;

namespace BettingApp.Core.Contracts
{
    public interface IBetService
    {
        public decimal GetBetsAmount(string userId);
        public Task<IEnumerable<BetViewModel>> GetUserBets(string userId);
    }
}
