using BettingApp.Core.Models.Transaction;

namespace BettingApp.Core.Contracts
{
    public interface ITransactionService
    {
        public Task<IEnumerable<TransactionModel>> ByUserAsync(string userId);
        public decimal TotalAmount(string userId);
        public Task DepositAsync(DepositFormModel model, string userId);
        public Task WithdrawAsync(WithdrawFormModel model, string userId);
        public Task<IEnumerable<string>> GetUserCards(string userId);
        public Task<bool> UserCardExists(string userId, string cardNumber);
        public Task AddUserCard(string userId, CreditCardModel model);
    }
}
