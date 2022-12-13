using Microsoft.AspNetCore.Mvc;
using MVCUnitTesting.Models;
using System.Diagnostics;

namespace MVCUnitTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
        }

        public IActionResult Index() //Se testea según los estándares 
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
    }
}