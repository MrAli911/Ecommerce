using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
  
    [Route("dashboard")]
    public class DashBoardController : Controller
    {
        public AdminAuth AdminAuth { get; set; }

       
        public ViewResult Index()
        {
            return View("~/Areas/Admin/Views/Dashboard/index.cshtml");
        }

        
        public async Task<IActionResult> AdminLogin(string returnUrl)
        {
            if (!ModelState.IsValid) return View();
            {
                if (AdminAuth.username == "admin" && AdminAuth.password == "admin")
                    return View("Dashboard" , "Index");
            }
            var authenticationProperties = new AuthenticationProperties()
            {
                IsPersistent = AdminAuth.RememberMe
            };

            var claim = new List<Claim>
            {
                new Claim(AdminAuth.username , "admin"),
                new Claim(AdminAuth.password , "admin")
            };

            var idntity = new ClaimsIdentity(claim ,CookieAuthenticationDefaults.AuthenticationScheme);
            var prenciple = new ClaimsPrincipal(idntity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prenciple , authenticationProperties);

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("index", "Dashboard");
        }

       
    }
    public class AdminAuth
    {
        [Display(Name ="Admin username")]
        [Required]
        public string username { get; set; } = "admin"; 

        [Display(Name = "Password")]
        [Required]
        public string password { get; set; } = "admin";    

        public bool  RememberMe { get; set; }

    }
}
