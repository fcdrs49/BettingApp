using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Transaction;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Enums;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BettingApp.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository repo;
        private readonly IBetService betService;

        public TransactionService(
            IRepository _repo, IBetService _betService)
        {
            repo = _repo;
            betService = _betService;
        }

        public async Task AddUserCard(string userId, CreditCardModel model)
        {
            var userCard = new UserCard()
            {
                UserId = userId,
                CardNumber = model.CardNumber,
                ExpirationMonth = model.ExpirationMonth,
                ExpirationYear = model.ExpirationYear
            };
            await repo.AddAsync(userCard);
            await repo.SaveChangesAsync();
        }

        public async Task DepositAsync(DepositFormModel model, string userId)
        {
            var transaction = new Transaction()
            {
                UserId = userId,
                Amount = model.Amount,
                CurrencyCode = "BGN",
                DateTime = DateTime.Now,
                TransactionType = TransactionType.Deposit,
                CardNumber = model.CardNumber
            };
            await repo.AddAsync(transaction);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionModel>> ByUserAsync(string userId)
        {
            return await repo.AllReadonly<Transaction>()
                .Where(t => t.UserId == userId)
                .Select(t => new TransactionModel()
                {
                    Amount = t.Amount,
                    CurrencyCode = "BGN",
                    TransactionType = t.TransactionType.ToString(),
                    DateTime = t.DateTime,
                    CreditCard = t.CardNumber
                })
                .ToListAsync();
        }

        public decimal TotalAmount(string userId)
        {
            return repo.AllReadonly<Transaction>()
                .Where(t => t.UserId == userId)
                .Sum(t => t.Amount);
        }

        public async Task<IEnumerable<string>> GetUserCards(string userId)
        {
            return await repo.AllReadonly<UserCard>()
                .Where(cc => cc.UserId == userId &&
                      (cc.ExpirationYear > DateTime.Now.Year ||
                      (cc.ExpirationYear == DateTime.Now.Year && cc.ExpirationMonth >= DateTime.Now.Month)))
                .Select(cc => cc.CardNumber)
                .ToListAsync();
        }

        public async Task<bool> UserCardExists(string userId, string cardNumber)
        {
            return await repo.AllReadonly<UserCard>()
                .Where(uc => uc.UserId == userId && uc.CardNumber == cardNumber)
                .AnyAsync();
        }

        public async Task WithdrawAsync(WithdrawFormModel model, string userId)
        {
            var transactionsAmount = TotalAmount(userId);
            var betsAmount = betService.GetBetsAmount(userId);
            var balance = transactionsAmount + betsAmount;
            if (model.Amount > balance)
            {
                throw new InvalidOperationException("Amount is bigger than balance!");
            }

            var transaction = new Transaction()
            {
                Amount = -model.Amount,
                CurrencyCode = "BGN",
                CardNumber = model.CreditCard,
                DateTime = DateTime.Now,
                TransactionType = TransactionType.Withdraw,
                UserId = userId
            };

            await repo.AddAsync(transaction);
            await repo.SaveChangesAsync();
        }
    }
}
