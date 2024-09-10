

namespace Clima.clases
{
    public class Meteorologo
    {
        public string Nombre { get; set; }  
        public string Especialidad { get; set; }
        public Meteorologo(string nombre, string especialidad) 
        { 
            Nombre = nombre;
            Especialidad = especialidad;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Meteorologo: {Nombre}");
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }
}
