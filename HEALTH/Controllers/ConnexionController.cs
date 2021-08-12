using HEALTH.Data;
using HEALTH.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HEALTH.Controllers
{
    public class ConnexionController : Controller
    {
        private HEALTHDbContext dbContext = new HEALTHDbContext();
        public IActionResult Index(string returnUrl)
        {
            //if (ViewBag.messageError == null) ViewBag.messageError = "hidden";
            ViewBag.returnUrl = string.IsNullOrWhiteSpace(returnUrl) ? returnUrl : string.Empty;
            return View();
        }
        [HttpPost]

        public  async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!dbContext.Users.Any(u => u.Login.Equals(model.LoginUser) && u.Password.Equals(model.LoginPassword)))
                {
                    ModelState.AddModelError("Login", "Login et/ou mot de passe incorrect");
                    ViewBag.messageError = true;
                    return View(model);
                }
                var identity = new ClaimsIdentity(new[] {new Claim(ClaimTypes.Name, model.LoginUser)}, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var loginAs = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }
            else
            {
                ModelState.AddModelError("Login", "Veuillez remplir correctement le formulaire");
                return View(model);
            }
            //var user = dbContext.Users.Where(u => u.Login.Equals(model.LoginUser) && u.Password.Equals(model.LoginPassword)).SingleOrDefault();
            //var nomPrenom = user.Nom + "  " + user.Prenom;
            //HttpContext.Session.SetString("nomPrenom", nomPrenom);
            //dbContext.connexions.Add(new Connexion { dateConnexion = DateTime.UtcNow, user = user });
            //db.SaveChanges();
            if (string.IsNullOrWhiteSpace(model.ReturnUrl) /*| model.ReturnUrl.Equals("/")*/)
                return RedirectToAction("Index", "Home");
            return RedirectToAction(model.ReturnUrl);
        }
    }
}
