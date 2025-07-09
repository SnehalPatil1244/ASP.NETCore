using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Snehal",
            //    Designation = "Manager",
            //    Salary = 25000
            //};

            var myEmployee = new List<Employee>
            { 
                new Employee  {EmpId = 101, EmpName = "Snehal", Designation = "Manager",Salary = 25000},
                new Employee  {EmpId = 102, EmpName = "Rohit", Designation = "Manager",Salary = 26000},
                new Employee  {EmpId = 103, EmpName = "Teju", Designation = "Manager",Salary = 27000},
                new Employee  {EmpId = 104, EmpName = "Sanika", Designation = "Manager",Salary = 28000},
                new Employee  {EmpId = 105, EmpName = "Amruta", Designation = "Manager",Salary = 29000},

            };

            ViewData["myEmployee"] = myEmployee;

            //ViewData["myEmployee"]= emp;
            //ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;
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
    }
}
