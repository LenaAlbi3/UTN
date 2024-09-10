
namespace Clima.clases
{
    public class RedClimatica
    {
        public string Jefe { get; set; }
        private List<Estacion> _estaciones = new List<Estacion>(2);
        public RedClimatica(string jefe, List<Estacion>estaciones)
        {
            Jefe = jefe;
            if (estaciones.Count< 2)
            {
                throw new Exception("Cant de estacione no validas");
            }
            _estaciones = estaciones;

            //foreach(var estacion in estaciones)
            //{
            //    _estaciones.Add(estacion);
            //}

        }    
        public void AgregarEstacion(Estacion estacion)
        {
            _estaciones.Add(estacion);
        }
    }
}
