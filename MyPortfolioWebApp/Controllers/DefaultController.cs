using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
