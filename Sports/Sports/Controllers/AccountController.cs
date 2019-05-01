using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using Sports.Models;
using Sports.ViewModels;
using static Sports.Models.Model;

namespace Sports.Controllers
{
    public class AccountController : Controller
    {
        private SportsContext db;

        public AccountController(SportsContext context)
        {
            this.db = context;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("TestList", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Athletes result = db.Athletes.Include(x => x.Roles).Where(x => x.AthleteName == model.Username && x.Password == model.Password).FirstOrDefault();
                if (result != null)
                {
                    ClaimsIdentity identity = null;
                    bool isAuthenticated = false;
                    if (result.Roles.Role == "Coach")
                    {
                        identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, model.Username),
                        new Claim(ClaimTypes.Role, "Coach")
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                        isAuthenticated = true;
                    }
                    if (result.Roles.Role == "Athlete")
                    {
                        //Create the identity for the user  
                        identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, model.Username),
                        new Claim(ClaimTypes.Role, "Athlete")
                        }, CookieAuthenticationDefaults.AuthenticationScheme);

                        isAuthenticated = true;
                    }
                    //Create the identity for the user  

                    if (isAuthenticated)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("TestList", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View();
        }

        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}