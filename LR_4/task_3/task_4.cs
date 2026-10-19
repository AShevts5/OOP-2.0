using System;
using static System.Console;

namespace OOP_2
{
    class MatrixTask_4
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

            // Поиск максимального и минимального элементов матрицы
            double max = arr[0, 0];
            double min = arr[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max) max = arr[i, j];
                    if (arr[i, j] < min) min = arr[i, j];
                }

            double diff = max - min;
            WriteLine($"Максимальный элемент: {max:F2}");
            WriteLine($"Минимальный элемент: {min:F2}");
            WriteLine($"Разность max - min: {diff:F2}");

            if (Math.Abs(diff) < 1e-9)
            {
                WriteLine("Разность равна 0 => деление невозможно");
                return;
            }

            // Все элементы матрицы делятся на разность
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = arr[i, j] / diff;

            Matrix.PrintMatrix(result, $"\nНовая матрица (элементы исходной, делённые на {diff:F2}):");
        }
    }
}