using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
