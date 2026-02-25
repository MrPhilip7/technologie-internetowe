using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
