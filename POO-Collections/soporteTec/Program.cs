public class Ticket
{
    public string Descripcion { get; set; }
    public int NroTicket { get; set; } = 0;
    public Ticket(int nroTicket, string desc) 
    {
        NroTicket = nroTicket;
        Descripcion = desc;
        
    }
}

class SistemaTickets
{
    private Queue<Ticket> cola = new Queue<Ticket>();
    private int SiguienteId = 0;
    public void AgregarTicket(string desc)
    {
        Ticket t = new Ticket(++SiguienteId, desc);
        cola.Enqueue(t);
        Console.WriteLine($"Ticket #{t.NroTicket} agregado: {t.Descripcion}");
    }
    public void ProcesarTicket()
    {
        if( cola.Count == 0 )
        {
            Console.WriteLine("No hay tickets para procesar");
            return;
        }
        // dequeue es como el pop de las pilas
        Ticket t = cola.Dequeue(); // se guarda en variable una vez que sale de la queue para poder mostrarlo
        Console.WriteLine($"Procesando ticket #{t.NroTicket}: {t.Descripcion}");
    }
    public void MostrarTickets()
    {
        if( cola.Count == 0 )
        {
            Console.WriteLine("No hay tickets pendientes");
            return;
        }
        Console.WriteLine("Tickets Pendientes: ");
        foreach(var ticket in cola) 
        {
            Console.WriteLine($"Ticket #{ticket.NroTicket}: {ticket.Descripcion}");
        }
    }

}

public class Program
{
    static void Main(string[] args)
    {
        int opc;
        SistemaTickets sist = new SistemaTickets();
       
        do
        {
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1. Agregar nuevo ticket");
            Console.WriteLine("2. Mostrar Ticket");
            Console.WriteLine("3. Procesar Ticket");
            Console.WriteLine("4. Salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese la descripbion del ticket: ");
                    string desc = Console.ReadLine();
                    sist.AgregarTicket(desc);
                    break;
                case 2:
                    sist.MostrarTickets();
                    break;
                case 3:
                    sist.ProcesarTicket();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }


        } while (opc != 5);
    }
}
