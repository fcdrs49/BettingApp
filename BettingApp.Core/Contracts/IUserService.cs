using BettingApp.Core.Models.User;

namespace BettingApp.Core.Contracts
{
    public interface IUserService
    {
        public decimal GetBalance(string userId);
        public Task<IEnumerable<UserServiceModel>> All();
    }
}
