using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtual.Modulos
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; } 

        public Tienda(string nombre) 
        {
            Nombre = nombre;
        }
        public void AgregarProd(Producto producto)
        {
            Productos.Add(producto);
        }
        public void QuitarProd(Producto producto)
        {
            Productos.Remove(producto);
        }

    }
}
