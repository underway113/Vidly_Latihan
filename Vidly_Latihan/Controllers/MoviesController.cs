using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Latihan.Models;
using Vidly_Latihan.ViewModels;
namespace Vidly_Latihan.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            { 
                name = "Frozne"
            };
            var customers = new List<Customer>
            {
                new Customer {Name ="Customer 1" },
                new Customer {Name ="Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return Content("TESTING");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        } 

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() { Id = 1, name = "A To Z Serial" },
                new Movie() { Id = 2, name = "Man In Black" },
                new Movie() {Id = 3, name = "Frozen 2" }
           };
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}