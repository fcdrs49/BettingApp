using Microsoft.AspNetCore.Mvc;
using BettingApp.Extensions;
using BettingApp.Core.Contracts;

namespace BettingApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ITransactionService transactionService;
        private readonly IBetService betService;

        public UserController(
            ITransactionService _transactionService,
            IBetService _betService)
        {
            transactionService = _transactionService;
            betService = _betService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public decimal GetBalance()
        {
            var userId = User.Id();
            var transactionsAmount = transactionService.GetTotalAsync(userId);
            var betsAmount = betService.GetBetsAmount(userId);
            return transactionsAmount - betsAmount;
        }

        [HttpGet]
        public async Task<IActionResult> UserBets()
        {
            var userId = User.Id();
            var bets = await betService.GetUserBets(userId);

            return PartialView("_BetsPartial", bets);
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions()
        {
            var userId = User.Id();
            return PartialView("_TransactionsPartial", await transactionService.GetByUserAsync(userId));
        }
    }
}
