using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
