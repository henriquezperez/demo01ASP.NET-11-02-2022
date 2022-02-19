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

        public IActionResult Suma(Acciones acciones)
        {
                //public IActionResult Suma(Double DatoN1, Double DatoN2)

            if (acciones.Dato1 > 10 || acciones.Dato2 > 10)
            {
                return View("NoMayores");
            }

            ViewBag.DatoN1v = acciones.Dato1;
            ViewBag.DatoN2v = acciones.Dato2;

            Double resultado = acciones.Dato1 + acciones.Dato2;
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

        public IActionResult Notas(){

            return View();
        }

        public IActionResult IngresoNotas(Double lab1, Double par1, Double lab2, Double par2, Double lab3, Double par3){
            ViewBag.l1 = lab1;
            ViewBag.l2 = lab2;
            ViewBag.l3 = lab3;
            ViewBag.p1 = par1;
            ViewBag.p2 = par2;
            ViewBag.p3 = par3;
            Double promLab = ((lab1+lab2+lab3)/3)*0.40;
            Double promPar = ((par1+par2+par3)/3)*0.60;
            Double promFinal= promLab + promPar;
            ViewBag.promf = promFinal;
            return View();
        }

        public IActionResult PeticionTypeGet(){
            return View();
        }
    }
}