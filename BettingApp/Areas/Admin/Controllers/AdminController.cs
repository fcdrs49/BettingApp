using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BettingApp.Areas.Admin.AdminConstants;

namespace BettingApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
    }
}
