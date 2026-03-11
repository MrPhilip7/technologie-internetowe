using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using technologieInternetowe.DAL;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public IActionResult FooterSites()
        {
            return View();
        }

    }
}
