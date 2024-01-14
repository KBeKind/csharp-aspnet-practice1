using core_web_app1.Models;
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
        public IActionResult LoginSuccess(LoginViewModel login)
        {

            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "Login Successful";
                    return View();
                }
            }
            ViewBag.Message = "Login Failed";
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "Dudeman",
                Password = "testpass"
            };
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel(){
                Username = "Dudeman",
                Password = "testpass"
                },
                new LoginViewModel(){
                    Username = "XXXXXXXX",
                    Password = "XXXXXXXX"
                },
                new LoginViewModel(){
                    Username = "XXXXXXX2",
                    Password = "notherpass"
                }
            };

            return View(users);

        }


        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostCreateAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            return RedirectToAction("CreateAccount");
        }

    }

}

