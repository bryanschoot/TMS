using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMS.Model;

namespace TMS.Controllers
{
    public class AccountController : Controller
    {
        private Factory.Factory factory;
        
        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(login);
        }
    }
}