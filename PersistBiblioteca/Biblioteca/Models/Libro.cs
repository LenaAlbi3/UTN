

namespace Biblioteca.Models
{
    public class Libro
    {
        public string Codigo { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int EjemplaresDisponibles { get; private set; }
        public Libro(string codigo, string titulo, string autor, int ejemplares) 
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            EjemplaresDisponibles = ejemplares;
        }
        public void SumarEjemplar()
        {
            EjemplaresDisponibles ++;
        }
        public void RestarEjemplar()
        {
            EjemplaresDisponibles--;
        }
    }
}
