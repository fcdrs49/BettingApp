using BettingApp.Core.Contracts;
using BettingApp.Core.Models.User;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ITransactionService transactionService;
        private readonly IBetService betService;
        private readonly IRepository repo;

        public UserService(ITransactionService _transactionService, IBetService _betService, IRepository _repo)
        {
            transactionService = _transactionService;
            betService = _betService;
            repo = _repo;
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            return await repo.AllReadonly<User>()
                .Select(u => new UserServiceModel()
                {
                    Balance = GetBalance(u.Id),
                    FullName = u.FirstName + " " + u.LastName,
                    EMail = u.Email,
                    PhoneNumber = u.PhoneNumber
                })
                .ToListAsync();
        }

        public decimal GetBalance(string userId)
        {
            var transactionsAmount = transactionService.TotalAmount(userId);
            var betsAmount = betService.GetBetsAmount(userId);
            return Math.Round(transactionsAmount + betsAmount,2);
        }
    }
}
