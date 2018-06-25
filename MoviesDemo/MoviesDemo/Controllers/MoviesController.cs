using MoviesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesDemo.Controllers
{
    public class MoviesController : Controller
    {


        public MovieRepository repo = new MovieRepository();
        //Composed of Actions
        //Action - Method

        //Movies/Display
        public ActionResult Display()
        {
            List<Movie> movies = repo.All();
            return View("Display", movies);
        }


        protected override void Dispose(bool disposing)
        {
            //Cleaning up the repository, in the future, if it needs it.
            var thing = repo as IDisposable;
            if (thing != null) thing.Dispose();

            base.Dispose(disposing);
        }



    }
}