

namespace Escuela.Modelos.Interfaces;
public class Estudiante : EntidadConNombre
{
    private int _edad;
    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value >= 0)
            {
                _edad = value;
            }
            else
            {
                throw new ArgumentException("La edad no debe ser negativa");
            }
        }
    }
    public Estudiante(string nombre, int edad) : base(nombre)
    {
        Edad = edad;
    }
    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Edad: {Edad}\n");
    }
    public void HacerProyecto()
    {
        Console.WriteLine("Ingresa el nombre del proyecto: ");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingresa los detalles del proyecto: ");
        string detalle = Console.ReadLine();    
        Proyecto p = new Proyecto(nom, detalle);
    }
}

