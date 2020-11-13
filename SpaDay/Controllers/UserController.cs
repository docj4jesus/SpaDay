using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here

            if (newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View("Index");
            }
            else 
            {
                ViewBag.error = "Passwords do not match. Please enter them again.";
                ViewBag.Username = newUser.Username;
                ViewBag.Email = newUser.Email;

                return View("Add");
            }
        }

    }
}
