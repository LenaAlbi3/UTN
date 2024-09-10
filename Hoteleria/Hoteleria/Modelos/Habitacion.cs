using Hoteleria.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria.Modelos
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public List<Servicio> Servicios { get; set; }
        public double TarifaBase { get; set; }
        public Habitacion(int numero, string tipo, double tarifaBase) 
        { 
            Numero = numero;
            Tipo = tipo;
            TarifaBase = tarifaBase;
        }
        public void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }
        public double CalcularTarifa(Temporada temporada) 
        {
            return temporada == Temporada.Alta ? TarifaBase * 1.5 : TarifaBase;
            //if(temporada == Temporada.Alta)
            //{
            //    return TarifaBase * 1.5;
            //}
            //    return TarifaBase;
        }
    }
}
