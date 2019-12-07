using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSTVideoInc.Models;

namespace RSTVideoInc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Happy Scrappy Hero Pup"};

            return View(movie);
        }
    }
}