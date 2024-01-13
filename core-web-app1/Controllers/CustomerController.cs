using core_web_app1.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_web_app1.Controllers
{
    public class CustomerController : Controller
    {

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "John Doe", Amount = 12000},
            new Customer() {Id = 2, Name = "Jane Doe", Amount = 14000},
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        // THE ATTRIBUTE ROUTING OF [Route("~/")] OVERRIDES THE ACTION ROUTING WITHIN Program.cs   
        // [Route("~/")]
        // ATTRIBUTE ROUTES OVERRIDE ANY OTHER PREDEFINED/CONVENTIONAL ROUTES WITHIN THE CONTROLLER
        [Route("~/sample/message")]
        public IActionResult Message()
        {
            return View();
        }
    }
}
