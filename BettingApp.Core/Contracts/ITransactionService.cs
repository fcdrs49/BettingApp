using BettingApp.Core.Models.Transaction;

namespace BettingApp.Core.Contracts
{
    public interface ITransactionService
    {
        public Task<IEnumerable<TransactionModel>> GetByUserAsync(string userId);
        public decimal GetTotalAsync(string userId);
    }
}
