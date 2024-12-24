using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _NavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
