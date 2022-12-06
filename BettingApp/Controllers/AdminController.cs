using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
