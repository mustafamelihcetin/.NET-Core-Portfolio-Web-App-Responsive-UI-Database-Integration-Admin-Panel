using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioWebApp.DAL.Context;
using MyPortfolioWebApp.DAL.Entities;
using System.Linq;

namespace MyPortfolioWebApp.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult DeleteExperience()
        {
            return View();
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = context.Experiences.Find(id);
            context.Experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
