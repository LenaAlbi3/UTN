

namespace Biblioteca.Models
{
    public static class SisBiblioteca
    {
        public static List<Libro> libros = new List<Libro>();
        public static List<Usuario> usuarios = new List<Usuario>();
        static readonly string ArchivoUsuario = "Usuario.txt";
        static readonly string ArchivoLibros = "Libro.txt";
        static public void AgregarLibro(Libro libro) => libros.Add(libro);
        static public void AgregarUsuario(Usuario usuario) => usuarios.Add(usuario);
        static public void Realizarprestamo(Libro libro, Usuario usuario)
        {
            if(libro.EjemplaresDisponibles > 0)
            {
                Prestamo prestamito = new Prestamo(libro, DateTime.Now);
                usuario.AgregarPrestamo(prestamito);
                libro.RestarEjemplar();
                Console.WriteLine("Libro prestado exitosamente");
            }
            else
            {
                Console.WriteLine("No hay ejemplares disponibles");
            }
        }
        static public void DevolverLibro(Libro libro, Usuario usuario)
        {
            
            Prestamo prestamo = usuario.PrestamoList.Find(p => p.Libro = libro);
            if (prestamo == null)
            {
                Console.WriteLine($"El usuario {usuario.Nombre} no realizo el prestamo del libro {libro.Titulo}");
            }
            else
            {
                usuario.QuitarPrestamo(prestamo);
                libro.SumarEjemplar();
                Console.WriteLine($"Libro '{libro.Titulo}' devuelto");
            }
        }
    }
}
