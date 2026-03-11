using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using technologieInternetowe.DAL;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class CategoryController : Controller
    {
        private readonly FilmsContext _context;

        public CategoryController(FilmsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Kategorie";
            return View(await _context.Categories.Include(c => c.Films).OrderBy(c => c.Name).ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await _context.Categories.Include(c => c.Films).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            ViewData["Title"] = category.Name;
            return View(category);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Dodaj kategorię";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Title"] = "Dodaj kategorię";
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            ViewData["Title"] = "Edytuj kategorię";
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Title"] = "Edytuj kategorię";
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.Include(c => c.Films).FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            ViewData["Title"] = "Usuń kategorię";
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null) _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
