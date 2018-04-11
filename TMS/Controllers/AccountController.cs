using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TMS.Model;

namespace TMS.Controllers
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authentication;

    public class AccountController : Controller
    {
        private IConfiguration Config;
        private Factory.Factory Factory;

        public AccountController(IConfiguration config)
        {
            this.Config = config;
            Factory = new Factory.Factory(this.Config);
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountModel model)
        {
            var AccountLogic = Factory.AccountLogic();
            if (ModelState.IsValid)
            {
                if (AccountLogic.CheckLogin(model))
                {
                    var claims = new List<Claim>
                    {
                        new Claim("Id", "1"),
                        new Claim(ClaimTypes.Email, model.Email),
                        new Claim(ClaimTypes.Role, "Admin"),
                        new Claim("ÌsAuth", "true")
                    };

                    ClaimsIdentity identity = new ClaimsIdentity(claims, "Cookie");
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    await this.HttpContext.SignInAsync(
                        scheme: "TMS",
                        principal: principal);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                scheme: "TMS");

            return RedirectToAction("Login");
        }
    }
}