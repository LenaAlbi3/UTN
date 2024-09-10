using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.Modelos
{
    public class ClaseAdicional
    {
        private string _nombre;
        private double _costo;
        public ClaseAdicional(string nombre, double costo)
        { 
            _nombre = nombre;
            _costo = costo;
        }
        public string Nombre => _nombre;
        public double Costo => _costo;
    }
}
