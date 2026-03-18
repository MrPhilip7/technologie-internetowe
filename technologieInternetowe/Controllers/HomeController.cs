using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using technologieInternetowe.DAL;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmsContext _db;

        public HomeController(FilmsContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeDashboardViewModel
            {
                FilmsCount = await _db.Films.CountAsync(),
                CategoriesCount = await _db.Categories.CountAsync(),
                LatestFilms = await _db.Films
                    .Include(f => f.Category)
                    .OrderByDescending(f => f.FilmId)
                    .Take(6)
                    .ToListAsync(),
                Categories = await _db.Categories
                    .OrderBy(c => c.Name)
                    .ToListAsync()
            };

            ViewData["Title"] = "Strona główna";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
