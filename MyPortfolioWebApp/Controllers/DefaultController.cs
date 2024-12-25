using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.b = "~/hola-master/images/hero-bg.jpg";
            return View();
        }
    }
}
