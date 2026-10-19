using System;
using static System.Console;

namespace OOP_2
{
    public static class Matrix
    {
        public static void FillRandom(double[,] matrix, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(minValue, maxValue);
        }

        public static void PrintMatrix(double[,] matrix, string text)
        {
            WriteLine(text);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Write($"{matrix[i, j],10:F2}");
                WriteLine();
            }
            WriteLine();
        }
    }

    class MatrixTask_1
    {
        static void Main1(string[] args)
        {
            int n;
            Write("Введите размер матрицы n: ");
            while (!int.TryParse(ReadLine(), out n) || n <= 0)
                Write("Окак, ошибочка! Введите целое число n > 0: ");

            double[,] arr = new double[n, n];
            Matrix.FillRandom(arr, -10, 11);
            Matrix.PrintMatrix(arr, $"\nИсходная матрица ({n}x{n}):");

            // Среднее арифметическое элементов главной диагонали
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i, i];
            double avg = sum / n;

            WriteLine($"Среднее арифметическое элементов главной диагонали: {avg:F2}");

            if (Math.Abs(avg) < 1e-9)
            {
                WriteLine("Среднее арифметическое равно 0 => деление невозможно");
                return;
            }

            // Все элементы исходной матрицы делятся на среднее
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = arr[i, j] / avg;

            Matrix.PrintMatrix(result, $"\nНовая матрица (элементы исходной, делённые на {avg:F2}):");
        }
    }
}