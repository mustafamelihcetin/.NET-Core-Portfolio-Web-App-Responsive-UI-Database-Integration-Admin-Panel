using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
