using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private VidlyContext _context;

        public CustomersController()
        {
            _context = new VidlyContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

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
            var customer = _context.Customers.Include(c => c.MemberShipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            Customer = _context.Customers.Include(c=>c.MemberShipType).SingleOrDefault(i => i.Id == id);
            if (Customer == null)
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