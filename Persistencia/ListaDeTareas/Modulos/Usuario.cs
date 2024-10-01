using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas.Modulos
{
    public class Usuario
    {
        public string NombreUsuario {  get; set; }
        public List<Tarea> Tareas { get; set; }
        public Usuario(string nombreUsuario) 
        {
            NombreUsuario = nombreUsuario;
            Tareas = new List<Tarea>();
        }
        // funcion flecha o land 
        public void AgregarTarea(Tarea tarea) => Tareas.Add(tarea);
        public void MostrarTareas()
        {
            Console.WriteLine($"\nTareas de {NombreUsuario}:");
            if(Tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas aun");
            }
            else
            {
                foreach (Tarea tarea in Tareas)
                {
                    Console.WriteLine(tarea.ToString());
                }
            }
            
        }
        public void CambiarEstadoTarea(int indice)
        {
            if (indice >= 0 && indice < Tareas.Count)
            {
                Tareas[indice].Completada = !Tareas[indice].Completada;
            }
            else
            {
                Console.WriteLine(new IndexOutOfRangeException().Message);
            }
        } 
    }
}
