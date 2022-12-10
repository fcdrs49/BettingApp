using BettingApp.Core.Models.Transaction;

namespace BettingApp.Core.Contracts
{
    public interface ITransactionService
    {
        public Task<IEnumerable<TransactionModel>> GetAllAsync();
    }
}
