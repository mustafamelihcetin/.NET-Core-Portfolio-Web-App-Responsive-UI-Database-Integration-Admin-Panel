using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
