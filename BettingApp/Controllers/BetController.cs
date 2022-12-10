using BettingApp.Core.Models.Bet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    [Authorize]
    public class BetController : Controller
    {
    }
}
