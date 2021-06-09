using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreApp.Utils;

namespace SampleCoreApp.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Add(int x=0, int y=0)
        {
            int sum = Calculator.Add(x, y);
            ViewBag.Message = String.Format("{0} + {1} = {2}", x, y, sum);
            return View();
        }
    }
}
