using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVirtual.Interfaces;

namespace TiendaVirtual.Modulos
{
    public class Categoria : Mostrable
    {
        public string NombreCategoria { get; set; } 
        public Categoria(string nombreCategoria)
        {
            NombreCategoria = nombreCategoria;         
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Categoria: {NombreCategoria}");
        }

    }
}
