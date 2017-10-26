using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Latihan.Models;

namespace Vidly_Latihan.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            { 
                name = "Frozne"
            };
            return View(movie);
        }
    }
}