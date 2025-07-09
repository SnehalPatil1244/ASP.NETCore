using ASPCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> Students = new List<Student>
            {
                new Student { Id = 1,Name = "Snehal",Gender = "Female",
                new Student { Id = 2,Name = "Rohit",Gender = "male",
                new Student { Id = 3,Name = "Teju",Gender = "Female",

            };
            return View(Students);
        }
        public IActionResult About()
        {
            List<Student> Students = new List<Student>
            {
                new Student { Id = 1,Name = "Snehal",Gender = "Female",
                new Student { Id = 2,Name = "Rohit",Gender = "male",
                new Student { Id = 3,Name = "Teju",Gender = "Female",

            };
            return View();
        }
        public IActionResult Contact()
        {
            List<Student> Students = new List<Student>
            {
                new Student { Id = 1,Name = "Snehal",Gender = "Female",
                new Student { Id = 2,Name = "Rohit",Gender = "male",
                new Student { Id = 3,Name = "Teju",Gender = "Female",

            };
            return View();
        }
    }
}
