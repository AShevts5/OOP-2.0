using System;
using static System.Console;

namespace OOP_2
{
    class ArrayTask_8
    {
        static void Main(string[] args)
        {
            int n = 12;
            double[] scores = new double[n];
            ArrayOperations.FillRandom(scores, 2.5, 5.0);   // успеваемость групп в баллах
            ArrayOperations.PrintArray(scores, "Успеваемость 12 учебных групп (баллы):");

            // Средний уровень успеваемости и самая отстающая группа
            double sum = 0;
            double min = scores[0];
            int minIndex = 0;
            for (int i = 0; i < n; i++)
            {
                sum += scores[i];
                if (scores[i] < min)
                {
                    min = scores[i];
                    minIndex = i;
                }
            }
            double avg = sum / n;

            WriteLine($"Средний уровень успеваемости: {avg:F2}");
            WriteLine($"Самая отстающая группа: №{minIndex + 1} ({min:F2} балла)");
            WriteLine($"Нужно повысить успеваемость на {avg - min:F2} балла");
        }
    }
}