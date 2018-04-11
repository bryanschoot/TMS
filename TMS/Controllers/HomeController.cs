using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TMS.Models;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace TMS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
