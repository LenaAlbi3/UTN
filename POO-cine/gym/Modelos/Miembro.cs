using gym.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.Modelos
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public TipoMembresia Membresia { get; private set; }
        public double CostoBaseMemb {
            get
            {
                switch (Membresia)
                {
                    case TipoMembresia.Basico:
                        return 30;
                    case TipoMembresia.Premium:
                        return 50;
                    case TipoMembresia.Vip:
                        return 80;
                    default:
                        return 0;
                }
            }
        }
        public List<ClaseAdicional> ClasesAdicionales { get; private set; } = new List<ClaseAdicional>();
        public bool AccesoPiscina => Membresia != TipoMembresia.Basico;
        public bool AccesoSpa => Membresia == TipoMembresia.Vip;
        public bool ClasesGrupales => Membresia != TipoMembresia.Basico;
        public double DescuentoEnClases
        {
            get
            {
                if (Membresia == TipoMembresia.Premium) return 0.1;
                if (Membresia == TipoMembresia.Vip) return 0.2;
                else return 0;
            }
        }
        public double CostoTotalClases
        {
            get
            {
                double costoTotal = 0;
                foreach(var clase in ClasesAdicionales)
                {
                    costoTotal += clase.Costo;
                }
            }
        }
        public double CostoMensualTotal => CostoTotalClases + CostoBaseMemb;
        public Miembro() 
        {
        
        }    
    }
}
