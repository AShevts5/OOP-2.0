using System;
using static System.Console;

namespace OOP_2
{
    public static class ArrayOperations
    {
        public static void FillRandom(int[] arr, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(minValue, maxValue);
        }

        public static void FillRandom(double[] arr, double minValue, double maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
        }

        public static void PrintArray(int[] arr, string text)
        {
            WriteLine(text);
            for (int i = 0; i < arr.Length; i++)
                Write($"{arr[i],5}");
            WriteLine();
            WriteLine();
        }

        public static void PrintArray(double[] arr, string text)
        {
            WriteLine(text);
            for (int i = 0; i < arr.Length; i++)
                Write($"{arr[i],8:F2}");
            WriteLine();
            WriteLine();
        }
    }

    class ArrayTask_5
    {
        static void Main(string[] args)
        {
            int n = 12;
            int[] arr = new int[n];
            ArrayOperations.FillRandom(arr, -50, 51);
            ArrayOperations.PrintArray(arr, "Исходный массив:");
            WriteLine($"Количество элементов: {n}\n");

            int m;
            Write($"Введите m (от 1 до {n - 1}): ");
            while (!int.TryParse(ReadLine(), out m) || m < 1 || m > n - 1)
                Write($"Окак, ошибочка! Введите число от 1 до {n - 1}: ");

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = arr[(i + m) % n];

            ArrayOperations.PrintArray(result, $"\nПреобразованный массив (части переставлены, m = {m}):");
        }
    }
}