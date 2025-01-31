using Microsoft.AspNetCore.Mvc;
using MyPortfolioWebApp.DAL.Context;

namespace MyPortfolioWebApp.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values = context.Messages.ToList();
			return View(values);
		}
	}
}
