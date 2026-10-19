using System;
using static System.Console;

namespace OOP_2
{
    class ArrayTask_9
    {
        static void Main1(string[] args)
        {
            int n = 10;
            double[] rates = new double[n];
            ArrayOperations.FillRandom(rates, 90.0, 100.0);   // курс покупки валюты банком, р
            ArrayOperations.PrintArray(rates, "Курс покупки валюты в 10 банках (руб.):");

            double max = rates[0];
            int maxIndex = 0;
            for (int i = 1; i < n; i++)
                if (rates[i] > max)
                {
                    max = rates[i];
                    maxIndex = i;
                }

            WriteLine($"Выгоднее всего продать валюту в банке №{maxIndex + 1} по курсу {max:F2} руб.");
        }
    }
}