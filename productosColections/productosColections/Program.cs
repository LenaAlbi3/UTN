class Producto
{
    public string Nombre { get; set; }
    public int TiempoProcesamiento { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        Queue<Producto> lineaProduccion = new Queue<Producto>();
        lineaProduccion.Enqueue(new Producto { Nombre = "laptop", TiempoProcesamiento = 6 });
        lineaProduccion.Enqueue(new Producto { Nombre = "Telefono", TiempoProcesamiento= 8 });
        lineaProduccion.Enqueue(new Producto { Nombre = "Mouse", TiempoProcesamiento = 2 });
        while(lineaProduccion.Count > 0)
        {
            Producto unProducto = lineaProduccion.Dequeue();
            Console.WriteLine($"Ensamblando {unProducto.Nombre} por {unProducto.TiempoProcesamiento}");
        }
    }
}
