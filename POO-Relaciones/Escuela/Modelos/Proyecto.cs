
namespace Escuela.Modelos.Interfaces;

public class Proyecto : EntidadConNombre
{
    public string Descripcion { get; set; }
    public Proyecto(string nombre, string descripcion) : base(nombre)
    {
        Descripcion = descripcion;
    }
    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Descripcion: {Descripcion}\n");
    }
    public void EvaluarProyecto(Evaluador evaluador)
    {
        Console.WriteLine($"{Nombre} esta siendo evaluado por {evaluador.Nombre}");
    }    
}



