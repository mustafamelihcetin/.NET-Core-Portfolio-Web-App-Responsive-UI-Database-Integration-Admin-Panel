using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
