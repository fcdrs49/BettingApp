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

        public TransactionService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<IEnumerable<TransactionModel>> GetAllAsync()
        {
            return await repo.AllReadonly<Transaction>()
                .Select(t => new TransactionModel()
                {
                    User = t.User.UserName,
                    Amount = t.Amount,
                    CurrencyCode = t.CurrencyCode,
                    Id = t.Id,
                    TransactionType = t.TransactionType.ToString()
                })
                .ToListAsync();
        }
    }
}
