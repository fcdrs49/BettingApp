using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Transaction;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository repo;

        public TransactionService(
            IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<TransactionModel>> GetByUserAsync(string userId)
        {
            return await repo.AllReadonly<Transaction>()
                .Where(t => t.UserId == userId)
                .Select(t => new TransactionModel()
                {
                    Amount = t.Amount,
                    CurrencyCode = t.CurrencyCode,
                    TransactionType = t.TransactionType.ToString(),
                    DateTime = t.DateTime
                })
                .ToListAsync();
        }

        public decimal GetTotalAsync(string userId)
        {
            return repo.AllReadonly<Transaction>()
                .Where(t => t.UserId == userId)
                .Sum(t => t.Amount);
        }
    }
}
