using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewAspCore.Models;

namespace StronglyTypedViewAspCore.Controllers
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
            Employee obj = new Employee()
            {
                EmpId = 101,
                EmpName = "Snehal",
                Designation = "Manager",
                Salary = 25000

            };
            return View(obj);
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
