using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TMS.Factory;
using TMS.Models;

namespace TMS.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration config;
        private UserFactory factory;

        public UserController(IConfiguration config)
        {
            this.config = config;
            factory = new UserFactory(config);
        }

        public IActionResult Index()
        {
            UserViewModel viewModel = new UserViewModel();

            var userLogic = factory.CreateUserLogic();
            viewModel.users = userLogic.GetAll();

            var data = config["ContextType:Type"];
            ViewData["Context"] = data;

            return View(viewModel);
        }
    }
}