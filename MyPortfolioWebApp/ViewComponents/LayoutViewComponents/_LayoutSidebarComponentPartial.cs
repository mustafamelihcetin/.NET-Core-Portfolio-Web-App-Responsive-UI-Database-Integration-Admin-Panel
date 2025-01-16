using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
