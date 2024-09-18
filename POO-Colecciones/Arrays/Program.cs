using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int[] numeritos = { 2, 6, 1, 3, 5, 4, 9, 8, 7 };
        for (int i = 0; i < numeritos.Length - 1; i++)
        {
            for (int j = i + 1; j < numeritos.Length; j++)
            {
                if (numeritos[j] > i)
                {
                    int aux = numeritos[j];
                    numeritos[j] = numeritos[i];
                    numeritos[i] = aux;


                }
            }
        }
        
        List<int> list = new List<int> { 1, 2, 3 };
        list.Add(4);

        int[] numeros2 = new int[4];
        numeros2[0] = 1;
        numeros2[1] = 2;
        numeros2[numeros2.Length - 1] = 3;
        IDictionary<char, string> letras = new Dictionary<char, string>();
        letras.Add('A', "A");
        letras.Add('B', "Be");
        letras.Add('C', "Ce");
        letras.Add('D', "De");
        letras.Add('E', "E");
        letras.Add('F', "Efe");
        Console.WriteLine(letras['F']);

        IDictionary<string, string> ingEsp = new Dictionary<string, string>();
        ingEsp.Add("House", "Casa");
        ingEsp.Add("Letter", "Carta");
        ingEsp.Add("Phone", "Telefono");
        ingEsp.Add("Keyboard", "Teclado");
        foreach(var word in ingEsp)
        {
            Console.WriteLine(word);
        }
        foreach(KeyValuePair<string, string> kvp in ingEsp)
        {
            Console.WriteLine(kvp.Key);
            Console.WriteLine(kvp.Value);
        }

        HashSet<int> set = new HashSet<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine(set.Contains(5));
        foreach(var num in set)
        {
            Console.WriteLine(num);
        }

    }
}
