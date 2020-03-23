using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>()
            {
                new Customer(){Id = 1,Name = "customer1"},
                new Customer(){Id = 2,Name = "customer2"}
            };
            var viewModel=new RandomMovieViewModel(){Customers = customers,Movie = movie};
            // return View(movie);
            // return RedirectToAction("Index", "Home");
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        // public ActionResult Index(int? pageNum, string sortBy)
        // {
        //     if (pageNum == null)
        //     {
        //         pageNum = 1;
        //     }
        //
        //     if (String.IsNullOrWhiteSpace(sortBy))
        //     {
        //         sortBy = "name";
        //     }
        //
        //     return Content("MovieID is:" + pageNum + " sortBy is:" + sortBy);
        // }
        [Route("movies/release/{Year:regex(\\d{4})}/{Month}")]
        public ActionResult ReleasedByDate(int? Month, int? Year)
        {
            if (Month == null)
            {
                Month = 04;
            }

            if (Year == null)
            {
                Year = 2016;
            }

            return Content(Year + "/" + Month);
        }
    }
}