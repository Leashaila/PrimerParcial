using Microsoft.AspNetCore.Mvc;

namespace PrimerParcial.Controllers
{
    public class PrincipalController : Controller
    {
        

        public IActionResult Bienvenido()
        {
            //ViewBag.Mensaje = "Bienvenid@ al sitio de evaluación";

            return View();
        }


        public IActionResult Resultados()
        {

            ViewBag.Areas = areas;

            return View();
        }

        public IActionResult IrACalcularAreaDeRectangulo()
        {



            return View();
        }
        
        [HttpPost]
        public IActionResult CalcularArea(int baseRectangulo, int alturaRectangulo)
        {
            if (baseRectangulo < 0 || baseRectangulo > 100 || alturaRectangulo < 0 || alturaRectangulo > 100) {
                ViewBag.Error = "La base y altura deben ser números entre 0 y 100.";
                    return View("IrACalcularAreaDeRectangulo");
            }

            else {
                // Calcular el área del rectángulo
                int area = baseRectangulo * alturaRectangulo;


                areas.Add(area);


                // Mostrar el resultado al usuario
                ViewBag.Area = area;
                return View("IrACalcularAreaDeRectangulo");

            }
        
        
        }



        }
}
