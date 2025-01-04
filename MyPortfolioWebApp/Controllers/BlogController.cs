using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioWebApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly MediumService _mediumService;

        public BlogController()
        {
            _mediumService = new MediumService();
        }

        public IActionResult Index()
        {
            List<BlogPost> posts = _mediumService.GetMediumPosts();
            return View(posts);
        }
    }
}
