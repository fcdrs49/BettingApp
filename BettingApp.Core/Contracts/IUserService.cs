namespace BettingApp.Core.Contracts
{
    public interface IUserService
    {
        public decimal GetBalance(string userId);
    }
}
