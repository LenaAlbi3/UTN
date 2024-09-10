

namespace Escuela.Modelos.Interfaces;

public class Aula : EntidadConNombre, IListaEditable<Estudiante>
{
    public Profesor profesor { get; set; }
    private List<Estudiante> _estudiantes = new List<Estudiante>();
    public List<Estudiante> Estudiantes { get { return _estudiantes; } }

    public Aula(string nombre, Profesor profe) : base(nombre)
    {
        profesor = profe;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        this.profesor.MostrarDetalles();
        Console.WriteLine("Estudiantes: ");
        foreach (var estudiante in _estudiantes)
        {
            estudiante.MostrarDetalles();

        }
        Console.WriteLine("\n");
    }
    public void Añadir(Estudiante entity)
    {
        _estudiantes.Add(entity);
    }

    public void Quitar(Estudiante entity)
    {
        _estudiantes.Remove(entity);
    }

}
