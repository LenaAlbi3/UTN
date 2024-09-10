

namespace Clima.clases
{
    public class Estacion
    {
        public Ubicacion Ubi { get; set; }
        public Meteorologo Meteoro { get; set; }
        public Estacion(Ubicacion ubi, Meteorologo meteoro) 
        {
            Ubi = ubi;
            Meteoro = meteoro;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles de la estacion: ");
            Ubi.MostrarDetalles();
            Meteoro.MostrarDetalles();
        }
    }
}
