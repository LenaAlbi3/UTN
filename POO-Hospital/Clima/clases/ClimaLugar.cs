

namespace Clima.clases
{
    public class ClimaLugar
    {
        public decimal TemperaturaC { get; set; }
        public string Condicion { get; set; }
        public ClimaLugar(decimal temperaturaC, string condicion)
        {
            TemperaturaC = temperaturaC;
            Condicion = condicion;
        }

        public void MostrarDetalles() 
        {
            Console.WriteLine($"Temperatura: {TemperaturaC}°C\n");
        }
    }
}
