using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            User newUser = new User()
            {
                Username = "Hello, Test",
            };
            return View(newUser);
        }

        public IActionResult Add()
        {
            AddUserViewModel login = new AddUserViewModel();
            return View(login);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel login)
        {
            if (ModelState.IsValid)
            {
                if (login.Password == login.VerifyPassword)
                {
                    User newUser = new User()
                    {
                        Username = login.Username,
                        Email = login.Email,
                        Password = login.Password
                    };
                    return View("Index", newUser);
                }
                else
                {
                    ViewBag.error = "Passwords do not match! Try again!";
                    ViewBag.Username = login.Username;
                    ViewBag.Email = login.Email;
                    return View("Add", login);
                }

            }

            return View("Add", login);
        }

    }
}
