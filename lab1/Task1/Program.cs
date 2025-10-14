using System;

namespace Task1
{
    public class Program
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            else
            {
                return "Двері зачинені...";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int number = int.Parse(Console.ReadLine());
            string message = GetMessage(number);
            Console.WriteLine(message);
        }
    }
}