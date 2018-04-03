using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TMS.Model;
using TMS.Models;

namespace TMS.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration config;
        private Factory.Factory factory;
        UserViewModel userViewModel = new UserViewModel();

        public UserController(IConfiguration config)
        {
            this.config = config;
            factory = new Factory.Factory(config);
        }

        public IActionResult Index()
        {
            var userLogic = factory.CreateUserLogic();
            userViewModel.users = userLogic.GetAll();

            return View(userViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}