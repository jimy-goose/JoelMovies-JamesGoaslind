using JoelMovies_JamesGoaslind.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JoelMovies_JamesGoaslind.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext temp) 
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
            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovies(Movie response)
        { // This checks if there were null values and valid values and either submits the form or tells them to fix it
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to database
                _context.SaveChanges();
                return RedirectToAction("Thanks");
            }
            else
            {

                if (response.Rating != null)
                {
                    
                    // Year is nullable and is null, so proceed without error
                    _context.Movies.Add(response); // Add record to database
                    _context.SaveChanges();
                    return RedirectToAction("Thanks");
                }
                else
                {
                    ViewBag.Category = _context.Categories
                        .OrderBy(x => x.CategoryName)
                        .ToList();
                    return View();
                }
                
            }
            
        }
        public IActionResult Thanks()
        {
            return View();
        }

        public IActionResult Movies()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("NewMovies", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Movies");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
               .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie deletedInfo)
        {
            _context.Movies.Remove(deletedInfo);
            _context.SaveChanges();

            return RedirectToAction("Movies");
        }
    }   
        
}
