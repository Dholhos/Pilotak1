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
        Console.WriteLine("3. feladat: {0}",adatSor);
        string seged = lista.Last();
        Console.WriteLine("4. feladat: {0}", seged[0]);
        Console.WriteLine("5. feladat");
    }
    
}