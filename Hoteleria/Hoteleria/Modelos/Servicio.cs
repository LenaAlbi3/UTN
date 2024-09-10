using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria.Modelos
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public Servicio(string nombre, double costo) 
        {
            Nombre = nombre;
            Costo = costo;
        }
    }
}


