using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using technologieInternetowe.DAL;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class FilmsController : Controller
    {
        private readonly FilmsContext _context;

        public FilmsController(FilmsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string search)
        {
            var films = _context.Films.Include(f => f.Category).AsQueryable();
            if (!string.IsNullOrEmpty(search))
                films = films.Where(f => f.Title.Contains(search) || f.Director.Contains(search));

            ViewData["Title"] = "Filmy";
            ViewData["Search"] = search;
            return View(await films.OrderBy(f => f.Title).ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var film = await _context.Films.Include(f => f.Category).FirstOrDefaultAsync(f => f.FilmId == id);
            if (film == null) return NotFound();
            ViewData["Title"] = film.Title;
            return View(film);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Dodaj film";
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Films.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Title"] = "Dodaj film";
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", film.CategoryId);
            return View(film);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film == null) return NotFound();
            ViewData["Title"] = "Edytuj film";
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", film.CategoryId);
            return View(film);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Film film)
        {
            if (id != film.FilmId) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Films.Update(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Title"] = "Edytuj film";
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", film.CategoryId);
            return View(film);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var film = await _context.Films.Include(f => f.Category).FirstOrDefaultAsync(f => f.FilmId == id);
            if (film == null) return NotFound();
            ViewData["Title"] = "Usuń film";
            return View(film);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film != null) _context.Films.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
