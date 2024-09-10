

using Escuela.Modelos.Interfaces;

namespace Escuela.Modelos
{
    public class Escuela : EntidadConNombre, IListaEditable<Aula>
    {
        public Administrador Admin { get; set; }
        private List<Aula> _aulas = new List<Aula>();
        public List<Aula> Aulas { get { return _aulas; } }
        public Escuela(string nombre, Administrador admin) : base(nombre)
        {
            Admin = admin;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Admin.MostrarDetalles();
            Console.WriteLine("Aulas: ");
            foreach (var aula in _aulas)
            {
                aula.MostrarDetalles();

            }
            Console.WriteLine("\n");
        }
        public void Añadir(Aula entity)
        {
            _aulas.Add(entity);
        }

        public void Quitar(Aula entity)
        {
            _aulas.Remove(entity);
        }
    }

}
