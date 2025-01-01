using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioWebApp.DAL.Context;
using MyPortfolioWebApp.DAL.Entities;
using System.Linq;

namespace MyPortfolioWebApp.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly MyPortfolioContext _context;

        public ExperienceController(MyPortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Veritabanından tüm deneyimleri liste olarak al
            var model = _context.Experiences?.ToList() ?? new List<Experience>();
            return View(model);
        }

        public IActionResult ExperienceList()
        {
            var values = _context.Experiences?.ToList() ?? new List<Experience>();
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
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                return RedirectToAction("ExperienceList");
            }
            return View(experience);
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Experiences.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Update(experience);
                _context.SaveChanges();
                return RedirectToAction("ExperienceList");
            }
            return View(experience);
        }
    }
}
