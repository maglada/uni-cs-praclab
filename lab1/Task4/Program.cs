using System;


namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Invalid triangle sides.");
            }
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Invalid triangle sides.");
            }
            double s = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        private static bool IsTriangle(double a, double b, double c)
        {
            return Math.Abs(a * a + b * b - c * c) < 1e-10 ||
                   Math.Abs(a * a + c * c - b * b) < 1e-10 ||
                   Math.Abs(b * b + c * c - a * a) < 1e-10;
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Invalid triangle sides.");
            }
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            else if (a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }
            else if (IsTriangle(a, b, c))
            {
                return "прямокутний";
            }
            else
            {
                return "довільний";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжини трьох сторін трикутника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine($"Периметр: {GetPerimeter(a, b, c)}");
                Console.WriteLine($"Площа: {GetArea(a, b, c)}");
                Console.WriteLine($"Тип трикутника: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
            }
        }
    }
}