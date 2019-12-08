using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSTVideoInc.Models;
using RSTVideoInc.ViewModels;

namespace RSTVideoInc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Happy Scrappy Hero Pup"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}