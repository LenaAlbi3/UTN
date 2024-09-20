public class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set;}
    public int Cantidad { get; set; }
    public Producto(int codigo, string nombre, int cant) 
    {
        Codigo = codigo;
        Nombre = nombre;
        Cantidad = cant;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        int opc;
        Dictionary<int, Producto> Almacen = new Dictionary<int, Producto>();
        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Actualizar stock");
            Console.WriteLine("3. Mostrar productos en stock");
            Console.WriteLine("4. Salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingrese el codigo: ");
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    Producto p = new Producto(code, name, stock);
                    Almacen.TryAdd(code, p);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el codigo del producto a actualizar: ");
                    int codeAAct = int.Parse(Console.ReadLine());
                    if (Almacen.ContainsKey(codeAAct))
                    {
                        Console.WriteLine("Ingrese la nueva cantidad: ");
                        int stockNuevo = int.Parse(Console.ReadLine());
                        Almacen[codeAAct].Cantidad += stockNuevo;
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                    Console.ReadKey();
                    break; 
                case 3:
                    Console.WriteLine("Productos en stock:");
                    foreach (var pr in Almacen.Values)
                    {
                        Console.WriteLine($"Codigo: {pr.Codigo}\n Nombre: {pr.Nombre}\n Cantidad en stock: {pr.Cantidad}");
                    }
                    Console.ReadKey();
                    break; 
            }
        } while (opc != 4);
        
    }
}
