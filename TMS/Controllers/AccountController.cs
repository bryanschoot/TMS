using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TMS.Model;

namespace TMS.Controllers
{
    public class AccountController : Controller
    {
        private IConfiguration Config;
        private Factory.Factory Factory;

        public AccountController(IConfiguration config)
        {
            this.Config = config;
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
            Factory = new Factory.Factory(this.Config);
            var AccountLogic = Factory.AccountLogic();
            if (ModelState.IsValid)
            {
                if (AccountLogic.CheckLogin(model))
                {

                }
            }
            return View(model);
        }
    }
}