using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioWebApp.DAL.Context;
using MyPortfolioWebApp.DAL.Entities;

namespace MyPortfolioWebApp.Controllers
{
    public class ExperienceController:Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var model = _context.Experiences.ToList();
            return View(model);
        }

        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.ToList();
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
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
