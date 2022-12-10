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
    }
}
