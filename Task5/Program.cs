using System;

namespace Task5
{
    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                throw new ArgumentException("Array is null or empty");

            double sum = 0;
            foreach (var mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                throw new ArgumentException("Array is null or empty");

            int min = marks[0];
            foreach (var mark in marks)
            {
                if (mark < min)
                    min = mark;
            }
            return min;
        }

        public static int GetMax(int[] marks)
        {
            if (marks == null || marks.Length == 0)
                throw new ArgumentException("Array is null or empty");

            int max = marks[0];
            foreach (var mark in marks)
            {
                if (mark > max)
                    max = mark;
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[][] groups = new int[3][]
            {
                new int[] { 80, 90, 70, 60, 100 },
                new int[] { 50, 75, 85, 95, 65 },
                new int[] { 90, 92, 96, 98, 100 }
            };
            for (int i = 0; i < groups.Length; i++)
            {
                double average = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);
                Console.WriteLine($"Група {i + 1}: Середній = {average}, Мінімальний = {min}, Максимальний = {max}");
            }

        }
    }
}