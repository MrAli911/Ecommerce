using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AccountController : Controller
    {
       
       
        [HttpGet]
        [Route("signup")]
        [Alloanoymous]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("signup")]
        public IActionResult SignUp(SignUpUserModel model)
        {
            if (ModelState.IsValid)
            {
                //
                ModelState.Clear();

            }
            return View(model); 
        }
        [Authorize]
        public IActionResult SignIn()
        {
           return View();
        }
        [Authorize]
        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }

    }
    

    internal class AlloanoymousAttribute : Attribute
    {
    }
}
