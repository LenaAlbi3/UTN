

namespace Biblioteca.Models
{
    public class Prestamo
    {
        public Libro Libro { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime FechaDevolucion { get ; private set; }  

        public Prestamo(Libro libro, DateTime fechaPrestamo) 
        {
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = FechaPrestamo.AddDays(10);
        }
    }
}
