
namespace ListaDeTareas.Modulos
{
    public class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        // bool completada = false es un valor por defecto, si se ingresa un valor a
        // parte toma el valor ingresado y si no se ingresa nada toma el valor por defecto
        public Tarea(string descripcion, bool completada = false) 
        {
            Descripcion = descripcion;
            Completada = completada;
        }

        // manera util de poner los detalles de algo
        public override string ToString()
        {
            // expresion ternaria que pregunta si es verdadero o falso y retorna la palabra o expresion elegida
            return $"{Descripcion} - {(Completada?"Completada": "Pendiente")}";

        }
    }

}
