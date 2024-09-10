using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVirtual.Interfaces;

namespace TiendaVirtual.Modulos
{
    public class Producto : Mostrable
    {
        public string NombreProd { get; set; }
        public Categoria CategoriaProd { get; set; }
        public int CantStock { get; set; }
        public double Precio { get; set; }
        
        public Producto(string nombreProd, Categoria categoriaProd, int cantStock, double precio) 
        {
            NombreProd = nombreProd;
            CategoriaProd = categoriaProd;
            CantStock = cantStock;
            Precio = precio;
            
            
        }
        public void MostrarInfo() 
        {
            Console.WriteLine($"Producto: {NombreProd}" +
                $"Categoria: {CategoriaProd}" +
                $"Cantidad de Stock: {CantStock}" +
                $"Precio: {Precio}");
                
        
        }
    }
}
