using Microsoft.AspNetCore.Mvc;
using MyPortfolioWebApp.DAL.Context;

namespace MyPortfolioWebApp.Controllers
{
    public class StatisticController : Controller
    {        
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Count();
            return View();
        }
    }
}
