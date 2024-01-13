﻿using core_web_app1.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_web_app1.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult WeaklyTypedLogin()
		{
			return View();
		}

		[HttpPost]
		public IActionResult LoginPost(string username, string password)
		{
			ViewBag.Username = username;
			ViewBag.Password = password;
			return View();
		}

		public IActionResult StronglyTypedLogin()
		{

			return View();
		}

		[HttpPost]
		public IActionResult LoginSuccess(LoginViewModel login) {
		
			ViewBag.Username = login.Username;
			ViewBag.Password = login.Password;
			return View();

		}
	}
}