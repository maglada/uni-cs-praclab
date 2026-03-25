using System;
using System.IO;
using Service;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Module1Service();

            File.WriteAllText("resultPD21.txt", "");

            service.ProcessFile(service.Uppercase);
            service.ProcessFile(service.WordCount);
            service.ProcessFile(service.SymbolCount);

            Console.WriteLine("Done! Results written to resultPD21.txt");
            Console.WriteLine(File.ReadAllText("resultPD21.txt"));
        }
    }
}
