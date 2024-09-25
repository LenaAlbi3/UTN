class Estudiante
{
    public string Nombre { get; set; }
    public List<string> Materias { get; set; } = new List<string>();
    public Estudiante(string nombre, List <string>materias)
    {
        Nombre = nombre;
        Materias = materias;

    }
    public void AgregarMateria(string mat)
    {
        Materias.Add(mat);

    }
    public void MostrarMaterias()
    {
        
        foreach (var mat in Materias)
        {
            Console.WriteLine($"{mat}");
        }
    }
    
}

class GrupoEstudio
{
    public string NombreGrupo { get; set; }
    public List<Estudiante> Estudiantes { get; set; } 
    public GrupoEstudio(string nombregrupo)
    {
        NombreGrupo = nombregrupo;
        Estudiantes = new List<Estudiante>();
    }
    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
        
    }
    public void MostrarDetalles()
    {

        foreach (var est in Estudiantes)
        {
            Console.WriteLine($"{est}");
            est.MostrarMaterias();
        }
    }
    public void MostrarEstudiantePorMateria(string materia)
    {
        Console.WriteLine($"Estudiantes en el grupo {NombreGrupo} que estan inscriptos en {materia}");
        foreach (var est in Estudiantes) 
        {
            if (est.Materias.Contains(materia))
            {
                Console.WriteLine($"- {est.Nombre}");
            }
            
        }
    }

}

public static class SistemaGrupos
{
    static Dictionary<string, GrupoEstudio> grupos = new Dictionary<string, GrupoEstudio> ();

    public static void CrearGrupo()
    {
        Console.Write("Ingrese el nombre del grupo");
        string nomGrupo = Console.ReadLine();
        grupos[nomGrupo] = new GrupoEstudio(nomGrupo);
        Console.WriteLine($"Grupo de estudio '{nomGrupo}' creado.");
    }
    public static void AgregarEstudiante()
    {
        Console.Write("Ingrese el nombre del grupo al que desea agregar el estudiante: ");
        string nomGrupo = Console.ReadLine();
        if (grupos.ContainsKey(nomGrupo))
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nomEst = Console.ReadLine();
            Console.Write("\nIngrese las materias del estudiante: ");
            string materiasInput = Console.ReadLine();
            List<string> Materias = new List<string>(materiasInput.Split(","));
            Estudiante estudiante = new Estudiante(nomEst, Materias);
            grupos[nomGrupo].AgregarEstudiante(estudiante);
            Console.WriteLine($"Estudiante {nomEst} agregado al grupo {nomGrupo} correctamente.");
        }
        else
        {
            Console.WriteLine("El grupo no existe.");
        }
    }
    public static void MostrarEstudiantePorMateria()
    {
        Console.WriteLine("Ingrese el nombre del grupo");
        string nomGrupo = Console.ReadLine();
        if (grupos.ContainsKey(nomGrupo))
        {
            Console.Write("Ingrese la materia para filtrar: ");
            string nomMateria = Console.ReadLine();
            grupos[nomGrupo].MostrarEstudiantePorMateria(nomMateria);
        }
        else
        {
            Console.WriteLine("El grupo no existe.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int opc = 0;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Crear grupo de estudio");
            Console.WriteLine("2. Añadir estudiante a un grupo");
            Console.WriteLine("3. Mostrar los estudiantes inscriptos en una materia");
            Console.WriteLine("4. Salir...");
            switch( opc )
            {
                case 1:
                    SistemaGrupos.CrearGrupo();
                    break;
                case 2:
                    SistemaGrupos.AgregarEstudiante();
                    break;
                case 3:
                    SistemaGrupos.MostrarEstudiantePorMateria();
                    break;
                case 4:
                    Console.WriteLine("Saliendooo");
                    break;
                default:
                    break;

            }

        } while (opc != 4);
    }
}
