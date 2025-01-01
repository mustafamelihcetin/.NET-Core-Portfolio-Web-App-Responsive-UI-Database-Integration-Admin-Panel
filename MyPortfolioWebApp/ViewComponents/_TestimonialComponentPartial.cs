using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
