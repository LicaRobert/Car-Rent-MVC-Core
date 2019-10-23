using System.Threading.Tasks;
using CarRentWebApp.Models;
using CarRentWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRentWebApp.Controllers
{
    public class AccountController : Controller
    {

        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginView)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(loginView.Name, loginView.Password, isPersistent: false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");

            }
            return View(loginView);
        }
    }
}