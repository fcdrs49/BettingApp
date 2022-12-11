using Microsoft.AspNetCore.Mvc;
using BettingApp.Extensions;
using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Transaction;

namespace BettingApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ITransactionService transactionService;
        private readonly IBetService betService;
        private readonly ICurrencyService currencyService;
        private readonly IUserService userService;

        public UserController(
            ITransactionService _transactionService,
            IBetService _betService,
            ICurrencyService _currencyService,
            IUserService _userService)
        {
            transactionService = _transactionService;
            betService = _betService;
            currencyService = _currencyService;
            userService = _userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public decimal GetBalance()
        {
            return userService.GetBalance(User.Id());
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

        [HttpGet]
        public async Task<IActionResult> Deposit()
        {
            var model = new DepositFormModel();
            var currencies = await currencyService.AllAsync();
            model.Currencies = currencies.Select(c => c.ISOCode).ToList();

            return PartialView("_DepositPartial", model);
        }

        [HttpPost]
        public async Task<IActionResult> Deposit(DepositFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var userId = User.Id();

            if(!await transactionService.UserCardExists(userId, model.CardNumber))
            {
                var creditCardModel = new CreditCardModel()
                {
                    CardNumber = model.CardNumber,
                    ExpirationMonth = model.ExpirationMonth,
                    ExpirationYear = model.ExpirationYear
                };
                await transactionService.AddUserCard(userId, creditCardModel);
            }

            await transactionService.DepositAsync(model, userId);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Withdraw()
        {
            var cards = await transactionService.GetUserCards(User.Id());

            var model = new WithdrawFormModel();
            model.CreditCards = cards;

            return PartialView("_WithdrawPartial", model);
        }

        [HttpPost]
        public async Task<IActionResult> Withdraw(WithdrawFormModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            await transactionService.WithdrawAsync(model, User.Id());
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Balance()
        {
            return View();
        }
    }
}
