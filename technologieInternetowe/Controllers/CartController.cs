using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using technologieInternetowe.DAL;
using technologieInternetowe.Extensions;
using technologieInternetowe.Models;

namespace technologieInternetowe.Controllers
{
    public class CartController : Controller
    {
        private readonly FilmsContext _context;

        public CartController(FilmsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            var film = _context.Films.Find(id);
            if (film != null)
            {
                var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
                var item = cart.FirstOrDefault(c => c.FilmId == id);
                
                if (item != null)
                {
                    item.Quantity++;
                }
                else
                {
                    cart.Add(new CartItem
                    {
                        FilmId = film.FilmId,
                        Title = film.Title,
                        Price = film.Price ?? 0,
                        Quantity = 1,
                        CoverImageUrl = film.CoverImageUrl
                    });
                }
                
                HttpContext.Session.Set("Cart", cart);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(c => c.FilmId == id);
            
            if (item != null)
            {
                cart.Remove(item);
                HttpContext.Session.Set("Cart", cart);
            }
            
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Decrease(int id)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(c => c.FilmId == id);
            
            if (item != null)
            {
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                }
                else
                {
                    cart.Remove(item);
                }
                HttpContext.Session.Set("Cart", cart);
            }
            
            return RedirectToAction("Index");
        }
    }
}
