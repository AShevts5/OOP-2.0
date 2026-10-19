using System;
using static System.Console;

namespace OOP_2
{
    class ArrayTask_6
    {
        static void Main(string[] args)
        {
            int n = 12;
            int[] arr = new int[n];
            ArrayOperations.FillRandom(arr, -50, 51);
            ArrayOperations.PrintArray(arr, "Исходный массив:");
            WriteLine($"Количество элементов: {n}\n");

            int k;
            Write($"Введите k (от 1 до {n - 1}): ");
            while (!int.TryParse(ReadLine(), out k) || k < 1 || k >= n)
                Write($"Окак, ошибочка! Введите число от 1 до {n - 1}: ");

            int[] result = new int[n];  
            for (int i = k; i < n; i++)
                result[i] = arr[i - k];

            ArrayOperations.PrintArray(result, $"\nПреобразованный массив (сдвиг вправо на {k}):");
        }
    }
}