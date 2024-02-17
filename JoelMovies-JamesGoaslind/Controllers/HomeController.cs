using JoelMovies_JamesGoaslind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JoelMovies_JamesGoaslind.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;

        public HomeController(NewMovieContext temp) 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovies(NewMovie response)
        { // This checks if there were null values and valid values and either submits the form or tells them to fix it
            if (ModelState.IsValid)
            {
                _context.NewMovies.Add(response); // Add record to database
                _context.SaveChanges();
                return RedirectToAction("Thanks");
            }
            else
            {

                if (response.Rating != null)
                {
                    // Year is nullable and is null, so proceed without error
                    _context.NewMovies.Add(response); // Add record to database
                    _context.SaveChanges();
                    return RedirectToAction("Thanks");
                }
                else
                {
                    return View();
                }
                
                
            }
            
        }
        public IActionResult Thanks()
        {
            return View();
        }

    }
}
