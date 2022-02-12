using demo01ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo01ASP.NET.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Ejercicio()
        {
            return View();
        }

        public IActionResult Suma(Double DatoN1, Double DatoN2)
        {

            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            ViewBag.DatoN1v = DatoN1;
            ViewBag.DatoN2v = DatoN2;

            Double resultado = DatoN1 + DatoN2;
            ViewBag.VariableEnviar = resultado;
            return View();
        }

        public IActionResult Resta(Double DatoN1, Double DatoN2)
        {

            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            ViewBag.DatoN1v = DatoN1;
            ViewBag.DatoN2v = DatoN2;

            Double resultado = DatoN1 - DatoN2;
            ViewBag.VariableEnviar = resultado;
            return View();
        }

        public IActionResult Multiplicacion(Double DatoN1, Double DatoN2)
        {

            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            ViewBag.DatoN1v = DatoN1;
            ViewBag.DatoN2v = DatoN2;

            Double resultado = DatoN1 * DatoN2;
            ViewBag.VariableEnviar = resultado;
            return View();
        }

        public IActionResult Division(Double DatoN1, Double DatoN2)
        {

            if (DatoN1 > 10 || DatoN2 > 10)
            {
                return View("NoMayores");
            }

            ViewBag.DatoN1v = DatoN1;
            ViewBag.DatoN2v = DatoN2;

            Double resultado = DatoN1 / DatoN2;
            if (DatoN2 == 0)
            {
                ViewBag.VariableEnviar = "No se puede dividir entre cero";
            }
            else
            {
                ViewBag.VariableEnviar = resultado;
            }
            return View();
        }

        public IActionResult NoMayores()
        {
            return View();
        }
    }
}