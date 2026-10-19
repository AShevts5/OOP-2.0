using System;
using static System.Console;

namespace OOP_2
{
    class ArrayTask_7
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            ArrayOperations.FillRandom(arr, -5, 6);
            ArrayOperations.PrintArray(arr, "Исходный массив:");

            // Поиск минимального и максимального значений
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            // Все минимальные элементы заменяются на максимум и наоборот
            int[] result = new int[n];
            int countMin = 0, countMax = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == min && min != max)
                {
                    result[i] = max;
                    countMin++;
                }
                else if (arr[i] == max && min != max)
                {
                    result[i] = min;
                    countMax++;
                }
                else
                {
                    result[i] = arr[i];
                }
            }

            WriteLine($"Минимальный элемент: {min}, количество: {countMin}");
            WriteLine($"Максимальный элемент: {max}, количество: {countMax}\n");

            ArrayOperations.PrintArray(result, "Преобразованный массив (минимальные и максимальные поменяны местами):");
        }
    }
}