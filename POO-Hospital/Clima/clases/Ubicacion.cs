

namespace Clima.clases
{
    public class Ubicacion
    {
        public string Ciudad { get ; set; }
        public string Pais { get; set; } 
        public ClimaLugar ClimaUb { get; set; }
        public Ubicacion(string ciudad, string pais, ClimaLugar climaUb)
        {
            Ciudad = ciudad;
            Pais = pais;
            ClimaUb = climaUb;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Ubicacion: ");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Pais: {Pais}");
            ClimaUb.MostrarDetalles();
        }
        public void ObtenerClima()
        {
            Console.WriteLine($"Ubicacion: {Ciudad}");
            ClimaUb.MostrarDetalles();
        }
    }
}
