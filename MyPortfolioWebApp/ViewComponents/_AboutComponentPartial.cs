using Microsoft.AspNetCore.Mvc;
using MyPortfolioWebApp.DAL.Context;

namespace MyPortfolioWebApp.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
