using System;


namespace Task3
{
    public class Program
    {
        public static string ClassifyAge(int age)
        {
            if (age >= 0 && age < 12)
            {
                return "Ви дитина";
            }
            else if (age >= 12 && age < 18)
            {
                return "Підліток";
            }
            else if (age >= 18 && age < 60)
            {
                return "Дорослий";
            }
            else if (age >= 60 && age <= 120)
            {
                return "Пенсіонер";
            }
            else
            {
                return "Нереальний вік";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть вік:");
            int age = int.Parse(Console.ReadLine());
            string category = ClassifyAge(age);
            Console.WriteLine("Категорія: " + category);
        }
    }
}