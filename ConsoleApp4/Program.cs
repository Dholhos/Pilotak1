using System.IO;
using System.Data.SqlTypes;
using ConsoleApp4;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        StreamReader sr = new StreamReader("Pilotak.csv");
        int adatSor = 0;
        string sor = sr.ReadLine();
        while (sor != null)
        {
            lista.Add(sor);
            adatSor++;
        }
        sr.Close();
        Console.WriteLine("3. feladat: {0}",adatSor-1);

        string seged = lista.Last();
        Console.WriteLine("4. feladat: {0}", seged[0]);

        foreach (var item in lista)
        {
            if ((item[1] < 1901)
            {
                Console.WriteLine(item[0], item[1]);
            }
        }
        Console.WriteLine("5. feladat");
    }
    
}