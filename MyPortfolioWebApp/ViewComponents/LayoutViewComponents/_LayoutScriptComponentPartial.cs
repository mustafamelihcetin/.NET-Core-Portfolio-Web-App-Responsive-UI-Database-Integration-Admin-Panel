using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
