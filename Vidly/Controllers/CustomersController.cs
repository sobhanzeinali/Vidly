using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public Customer Customer { get; set; }

        // GET: ICustomers
        public ActionResult Index()
        {
            // var Movie = new Movie() {Id = 1, Name = "Jack"};
            // ICustomers = new List<Customer>()
            // {
            //     new Customer() {Name = "Sam", Id = 1},
            //     new Customer() {Name = "JE", Id = 2}
            // };
            // var movieViewModel = new RandomMovieViewModel() {Customers = ICustomers, Movie = Movie};
            var customer = GetCustomers();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            Customer = GetCustomers().SingleOrDefault(i => i.Id == id);
            if (Customer==null)
            {
                return HttpNotFound();
            }
            return View(Customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Name = "Sam", Id = 1},
                new Customer() {Name = "JE", Id = 2}
            };
        }
    }
}