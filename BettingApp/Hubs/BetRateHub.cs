using Microsoft.AspNetCore.SignalR;

namespace BettingApp.Hubs
{
    public class BetRateHub : Hub
    {
        public async Task UpdateUserBets(string gameId, string homeRate, string drawRate, string awayRate)
        {
            await Clients.All.SendAsync("UpdateBetRates", gameId, homeRate, drawRate, awayRate);
        }

        public async Task SetGameFinished(string gameId, string homeTeamGoals, string awayTeamGoals)
        {
            await Clients.All.SendAsync("GameFinished", gameId, homeTeamGoals, awayTeamGoals);
        }
    }
}