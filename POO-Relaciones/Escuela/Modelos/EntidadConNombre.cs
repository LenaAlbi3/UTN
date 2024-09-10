

namespace Escuela.Modelos.Interfaces;

   public class EntidadConNombre : Interfaces.IMostrable
    {
        // privada para encapsulamiento
        private string _nombre = null!;
        // publica para poder acceder a ella desde fuera
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacio!");
                }
            }
        }
        public EntidadConNombre(string nombre)
        {
            Nombre = nombre;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}\n");
        }

    }

