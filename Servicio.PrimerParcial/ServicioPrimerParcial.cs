
namespace Servicio.PrimerParcial

{
    public class ServicioPrimerParcial : IServicioPrimerParcial
    {
        private static List<> areas = new List<int>();


        public int CalcularArea(int baseRectangulo, int alturaRectangulo)
        {
            if (baseRectangulo < 0 || baseRectangulo > 100 || alturaRectangulo < 0 || alturaRectangulo > 100)
            {

                return 0;
            }

            else
            {
                // Calcular el área del rectángulo
                int area = baseRectangulo * alturaRectangulo;


                areas.Add(area);
                
                return area;

            }


        }






    }
}