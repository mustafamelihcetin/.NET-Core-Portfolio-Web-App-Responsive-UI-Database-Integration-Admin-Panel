using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
