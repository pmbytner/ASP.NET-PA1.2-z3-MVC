using ASP.NET_PA1._2_z3_MVC.Models;
using ASP.NET_PA1._2_z3_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace ASP.NET_PA1._2_z3_MVC.Controllers
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

        public IActionResult Test(
            string imię,
            int? id = 0
            )
        {
            //ViewData["Imię"] = imię;
            //ViewBag.Id = id;
            return View(
                new HomeTestViewmodel()
                {
                    Id = id,
                    Imię = imię
                }
                );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel {
                    RequestId = Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier
                    }
                );
        }
    }
}