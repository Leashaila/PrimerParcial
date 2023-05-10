using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Servicio.PrimerParcial;

namespace PrimerParcial.Controllers
{
    public class PrincipalController : Controller
    {
        private IServicioPrimerParcial _primerParcialServicio;

        public PrincipalController(IServicioPrimerParcial primerParcialServicio)
        {
            _primerParcialServicio = primerParcialServicio;

        }


        public IActionResult Bienvenido()
        {
            //ViewBag.Mensaje = "Bienvenid@ al sitio de evaluación";

            return View();
        }


        public IActionResult Resultados()
        {



            return View();
        }

        public IActionResult IrACalcularAreaDeRectangulo()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CalcularArea(int baseRectangulo, int alturaRectangulo) {

           int resultado =  _primerParcialServicio.CalcularArea(baseRectangulo, alturaRectangulo);
            ViewBag.Area = "El area del rectangulo es:";
            ViewBag.Resultado = resultado;   
            return View("IrACalcularAreaDeRectangulo");


        
        }
        



        }
}
