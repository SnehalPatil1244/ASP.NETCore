using Microsoft.AspNetCore.Mvc;

namespace InstallingBoostrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
