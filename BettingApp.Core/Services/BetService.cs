using BettingApp.Core.Contracts;
using BettingApp.Core.Models.Bet;
using BettingApp.Core.Models.GameBet;
using BettingApp.Infrastructure.Data.Common;
using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BettingApp.Core.Services
{
    public class BetService : IBetService
    {
        private readonly IRepository repo;

        public BetService(IRepository _repo)
        {
            repo = _repo;
        }

        public decimal GetBetsAmount(string userId)
        {
            return repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Sum(b => b.WinAmount - b.Amount);
        }

        public async Task<IEnumerable<BetViewModel>> GetUserBets(string userId)
        {
            return await repo.AllReadonly<Bet>()
                .Where(b => b.UserId == userId)
                .Include(b => b.GameBets)
                .Select(b => new BetViewModel()
                {
                    Id = b.Id,
                    Amount = b.Amount,
                    CurrencyCode = b.CurrencyCode,
                    DateTime = b.DateTime,
                    Closed = b.Closed,
                    WinAmount = b.WinAmount,
                    GameBets = b.GameBets.Select(gb => new GameBetViewModel()
                    {
                        GameId = gb.GameId,
                        HomeTeam = gb.Game.HomeTeam.Name,
                        AwayTeam = gb.Game.AwayTeam.Name,
                        BetRate = gb.BetRate,
                        Prediction = gb.Prediction.ToString()
                    })
                    .ToList()
                })
                .ToListAsync();
        }
    }
}
