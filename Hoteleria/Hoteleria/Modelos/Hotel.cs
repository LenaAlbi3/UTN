using Hoteleria.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria.Modelos
{
    public class Hotel
    {
        public string Nombre { get; set; }
        public Temporada temporada { get; set; }
        public List<Habitacion> habitaciones { get; set; }

        public Hotel(string nombre) 
        {
            
        }
    }
}
