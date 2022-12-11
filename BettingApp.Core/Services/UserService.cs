using BettingApp.Core.Contracts;

namespace BettingApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ITransactionService transactionService;
        private readonly IBetService betService;

        public UserService(ITransactionService _transactionService, IBetService _betService)
        {
            transactionService = _transactionService;
            betService = _betService;
        }

        public decimal GetBalance(string userId)
        {
            var transactionsAmount = transactionService.GetTotalAsync(userId);
            var betsAmount = betService.GetBetsAmount(userId);
            return transactionsAmount + betsAmount;
        }
    }
}
