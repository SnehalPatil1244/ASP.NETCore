using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASP.NET.Models;
using ModelsInASP.NET.Repository;

namespace ModelsInASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository  = new StudentRepository();
        }
        public List <StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        public StudentModel getById(int Id)
        {
            return _studentRepository.getStudentById(Id);
        }
        public IActionResult Index()
        {
            //var Students = new List<StudentModel>
            //{
            //    new StudentModel()  { RollNo = 1 , Name = "Snehal" ,Gender = "Female", Standard = 11},
            //    new StudentModel()  { RollNo = 2 , Name = "Rohit" ,Gender = "male", Standard = 12},
            //    new StudentModel()  { RollNo = 3 , Name = "Teju" ,Gender = "Female", Standard = 10},

            //};
            //ViewData["mystudents"]=Students;

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
