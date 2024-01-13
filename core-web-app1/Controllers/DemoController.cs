using core_web_app1.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_web_app1.Controllers
{
	public class DemoController : Controller
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
			ViewData["Message"] = "Customer Management System";
			ViewData["CustomerCount"] = customers.Count();
			ViewData["CustomerList"] = customers;
			return View();
		}

		public IActionResult Method1()
		{
			TempData["Message"] = "Customer Management System";
			TempData["CustomerCount"] = customers.Count();
			TempData["CustomerList"] = customers;
			return View();
		}

		public IActionResult Method2()
		{
			if (TempData["Message"] == null)
			{
				return RedirectToAction("Index");
			}
			else
			{
				// COULD SAVE/SEND VALUES TO ViewBag or TempData or ViewData IT IS A CHOICE
				// I SIMPLY CHOSE TO SEND THEM TO TempData FOR SHORT TERM CONSISTANCY
				TempData["Message"] = TempData["Message"];
				return View();
			}
		}

		public IActionResult Login()
		{
			HttpContext.Session.SetString("username", "klee");
			return RedirectToAction("Success");
		}

		public IActionResult Success()
		{
			ViewBag.Username = HttpContext.Session.GetString("username");
			return View();
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Remove("username");
			return RedirectToAction("Index");
		}

		// REQUEST URL WITH THE QUERY STRING CHECK
		public IActionResult QueryTest()
		{
			string name = "Dudeman";
			if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
			{
				name = HttpContext.Request.Query["name"];
				ViewBag.Name = name;
				return View();

			}
			else
			{
				ViewBag.Name = name;
				return View();
			}

		}

	}
}
