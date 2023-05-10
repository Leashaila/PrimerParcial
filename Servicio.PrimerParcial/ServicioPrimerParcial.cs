using Modelo.PrimerParcial;
namespace Servicio.PrimerParcial

{
    public class ServicioPrimerParcial : IServicioPrimerParcial
    {
        private static List<ModeloRectangulo> areas = new List<ModeloRectangulo>();


        public int CalcularArea(int baseRectangulo, int alturaRectangulo)
            
        {
            if (baseRectangulo < 0 || baseRectangulo > 100 || alturaRectangulo < 0 || alturaRectangulo > 100)
            {

                return 0;
            }

            else
            {
                ModeloRectangulo modeloRectangulo = new ModeloRectangulo();
                modeloRectangulo.Id = GenerateId();
                modeloRectangulo.BaseRectangulo = baseRectangulo;
                modeloRectangulo.AlturaRectangulo = alturaRectangulo;
                // Calcular el área del rectángulo
                modeloRectangulo.Resultado = modeloRectangulo.BaseRectangulo * modeloRectangulo.AlturaRectangulo;
                int area = modeloRectangulo.Resultado;
                areas.Add(modeloRectangulo);
                
                return area;

            }


        }

        public int GenerateId()
        {
            int id = 1;

            if (areas.Count != 0)
            {

                id = areas.Max(o => o.Id + 1);

            }

            return id;
        }






    }
}