class Program
{
    static void Main(string[] args)
    {
        Stack<char> pila = new Stack<char>();

        Console.WriteLine("Escriba la frase: ");
        string frase = Console.ReadLine();
        foreach(var cadaLetra in frase)
        {
            // funcion push envia o agrega informacion a pila o array etc
            pila.Push(cadaLetra);
        }
        Console.WriteLine("Frase invertida: ");
        // con un pop quitamos elementos, cuidado porque elimina el elemento
        // y la informacion se pierde asi que hay q guardarla en algun lugar
        while(pila.Count > 0)
        {
            Console.Write(pila.Pop());
        }
    }
}
