using System.Diagnostics;
using _01HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01HelloWorld.Controllers
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
            var hora = DateTime.Now;
            ViewBag.hora = hora.ToString("hh:mm");

            if (hora.Hour >= 12)
            {
                ViewBag.Mensaje = "Ya son mas de las 12 del mediodía";
            }
            else
            {
                ViewBag.Mensaje = "Aún no son las 12 del mediodía";
            }

                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public string Nose()
        {
            return "Hello World";
        }


        public IActionResult Ines()
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
