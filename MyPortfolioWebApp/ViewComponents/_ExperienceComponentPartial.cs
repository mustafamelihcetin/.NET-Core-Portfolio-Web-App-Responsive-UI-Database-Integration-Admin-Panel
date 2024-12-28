using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
