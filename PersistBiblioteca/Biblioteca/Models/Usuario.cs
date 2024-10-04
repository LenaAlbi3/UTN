
namespace Biblioteca.Models
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public List<Prestamo> PrestamoList { get; private set; } = new List<Prestamo>();
        public Usuario(string nombre)
        {
            Nombre = nombre;
            
        }
        public void AgregarPrestamo(Prestamo prestamo)
        {
            PrestamoList.Add(prestamo);
        }
        public void QuitarPrestamo(Prestamo prestamo)
        {
            PrestamoList.Remove(prestamo);
        }
    }
}
