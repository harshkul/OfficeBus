using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeBus.Models;
using OfficeBus.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeBus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            RegisterVM vm = new RegisterVM();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Registration(RegisterVM registerVM)
        {
            if(ModelState.IsValid)
            {
                ModelState.AddModelError("", "User Already Exists.");
                return View(registerVM);
            }
            else
            {
                return View(registerVM);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
