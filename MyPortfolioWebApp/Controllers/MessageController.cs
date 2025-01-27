using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Inbox()
		{
			return View();
		}
	}
}
