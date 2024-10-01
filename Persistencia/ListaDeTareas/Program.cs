using ListaDeTareas.Modulos;

namespace ListaDeTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                Console.WriteLine("Ingrese la opcion");
                Console.WriteLine("1. Agregar Usuario");
                Console.WriteLine("2. Agregar Tarea al Usuario");
                Console.WriteLine("3. Cambiar estado de tarea");
                Console.WriteLine("4. Mostrar tareas de un usuario");
                Console.WriteLine("5. Guardar y salir");
                opc = int.Parse(Console.ReadLine());
                switch(opc) 
                {
                    case 1:
                        Sistema.AgregarUsuario();
                        break;
                    case 2:
                        Sistema.AgregarTareaAUsuario();
                        break;
                    case 3:
                        Sistema.CambiarEstadoTareaDeUsuario();
                        break;
                    case 4:
                        Sistema.MostrarTareasDeUsuario();
                        break;
                    case 5:

                        break;
                    default:
                        break;
                }
            } while (opc != 5);
            
        }
    }
}
