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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
//            var accountLogic = factory.CreateAccountLogic();
            return View("../Home/Index");
        }
    }
}