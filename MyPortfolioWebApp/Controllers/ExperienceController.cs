using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioWebApp.DAL.Context;
using MyPortfolioWebApp.DAL.Entities;
using System.Linq;

namespace MyPortfolioWebApp.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
