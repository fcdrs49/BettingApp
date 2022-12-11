using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.Transaction;

namespace BettingApp.Core.Models.User
{
    public class BalanceViewModel
    {
        public WithdrawFormModel Withdraw { get; set; } = null!;

        public DepositFormModel Deposit { get; set; } = null!;

        public IEnumerable<TransactionModel> Transactions { get; set; }
            = new List<TransactionModel>();

        public IEnumerable<BetViewModel> UserBets { get; set; }
            = new List<BetViewModel>();
    }
}
