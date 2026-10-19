using System;
using static System.Console;

namespace OOP_2
{
    class ArrayTask_10
    {
        static void Main(string[] args)
        {
            int n = 14;
            int[] arr = new int[n];
            ArrayOperations.FillRandom(arr, -20, 21);
            ArrayOperations.PrintArray(arr, "Исходный массив:");

            // Подсчёт, сколько элементов попадёт в каждый новый массив
            int countEven = 0, countNegative = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) countEven++;
                if (arr[i] < 0) countNegative++;
            }

            int[] even = new int[countEven];
            int[] negative = new int[countNegative];

            int e = 0, neg = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0) even[e++] = arr[i];
                if (arr[i] < 0) negative[neg++] = arr[i];
            }

            if (countEven > 0)
                ArrayOperations.PrintArray(even, $"Массив чётных элементов ({countEven} шт.):");
            else
                WriteLine("Чётных элементов нет\n");

            if (countNegative > 0)
                ArrayOperations.PrintArray(negative, $"Массив отрицательных элементов ({countNegative} шт.):");
            else
                WriteLine("Отрицательных элементов нет");
        }
    }
}