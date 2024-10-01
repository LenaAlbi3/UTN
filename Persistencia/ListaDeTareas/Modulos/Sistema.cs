using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas.Modulos
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> usuarios = new();
        public static void AgregarUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario: ");
            string NomUsuario = Console.ReadLine();
            if(!usuarios.ContainsKey(NomUsuario))
            {
                usuarios[NomUsuario] = new Usuario(NomUsuario);
                Console.WriteLine($"Usuario {NomUsuario} agregado");

            }
            else
            {
                Console.WriteLine("El usuario ya existe");
            }
        }
        // tarea poner completar tarea y llamar a funcion
        public static void AgregarTareaAUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nomUsuario = Console.ReadLine();
            if (usuarios.ContainsKey(nomUsuario))
            {
                Console.WriteLine("Ingrese la descripcion de la tarea: ");
                string desc = Console.ReadLine();

                Tarea tarea = new Tarea(desc);
                usuarios[nomUsuario].AgregarTarea(tarea);
                Console.WriteLine($"Tarea agregada al usuario {nomUsuario}");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }

        }
        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nomUsuario = Console.ReadLine();
            if (usuarios.ContainsKey(nomUsuario))
            {
                Console.Write("Ingrese el numero de la tarea a cambiar, empezando desde cero");
                int indice = int.Parse(Console.ReadLine());
                usuarios[nomUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }

        }
        public static void MostrarTareasDeUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nomUsuario = Console.ReadLine();
            if (usuarios.ContainsKey(nomUsuario))
            {
                usuarios[nomUsuario].MostrarTareas();
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }
        }

    }
}
