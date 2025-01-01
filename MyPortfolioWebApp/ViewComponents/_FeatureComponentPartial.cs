using Microsoft.AspNetCore.Mvc;
using MyPortfolioWebApp.DAL.Context;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
