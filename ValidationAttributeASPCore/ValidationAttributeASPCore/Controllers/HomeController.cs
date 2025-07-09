using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationAttributeASPCore.Models;

namespace ValidationAttributeASPCore.Controllers
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
        [HttpPost]
        public IActionResult Index(Student std)
        {
            return View();
            //if (ModelState.IsValid)
            //{
            //    return " Name : " + std.Name;
            //}
            //else
            //{
            //    return " validation failed..";
            //}
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
    }
}
