using BettingApp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService transactionService;

        public TransactionController(ITransactionService _transactionService)
        {
            transactionService = _transactionService;
        }

        public async Task<IActionResult> All()
        { 
            return View(await transactionService.GetAllAsync());
        }
    }
}
