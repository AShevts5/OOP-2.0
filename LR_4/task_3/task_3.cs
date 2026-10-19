using System;
using static System.Console;

namespace OOP_2
{
    class MatrixTask_3
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите размер матрицы n: ");
            while (!int.TryParse(ReadLine(), out n) || n <= 0)
                Write("Окак, ошибочка! Введите целое число n > 0: ");

            double[,] arr = new double[n, n];
            Matrix.FillRandom(arr, -10, 11);
            Matrix.PrintMatrix(arr, $"\nИсходная матрица ({n}x{n}):");

            int L;
            Write($"Введите номер строки L (от 1 до {n}): ");
            while (!int.TryParse(ReadLine(), out L) || L < 1 || L > n)
                Write($"Окак, ошибочка! Введите число от 1 до {n}: ");

            // Поиск минимального элемента в L-й строке 
            int row = L - 1;
            double min = arr[row, 0];
            for (int j = 1; j < n; j++)
                if (arr[row, j] < min)
                    min = arr[row, j];

            WriteLine($"\nМинимальный элемент {L}-й строки: {min:F2}");

            if (Math.Abs(min) < 1e-9)
            {
                WriteLine("Минимальный элемент равен 0 => деление невозможно");
                return;
            }

            // Все элементы матрицы делятся на минимум
            double[,] result = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = arr[i, j] / min;

            Matrix.PrintMatrix(result, $"\nНовая матрица (элементы исходной, делённые на {min:F2}):");
        }
    }
}