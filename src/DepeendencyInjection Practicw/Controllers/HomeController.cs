using DepeendencyInjection_Practicw.Models;
using DepeendencyInjection_Practicw.Models.Ireppository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DepeendencyInjection_Practicw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudent studentId;

        public HomeController(ILogger<HomeController> logger,IStudent get)
        {
            _logger = logger;
            studentId = get;
        }

        public int Index()
        {
            return studentId.add(new Student { Id=10});
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