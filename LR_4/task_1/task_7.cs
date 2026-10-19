using System;
using static System.Console;

namespace OOP_2
{
    class Task_7
    {
        static void Main1(string[] args)
        {
            try
            {
                // Первый способ
                Payment[] purchases1 =
                {
                    new Payment("Молоко", 3, 58.60, "бут."),
                    new Payment("Йогурт", 5, 38.20, "стак."),
                    new Payment("Творог", 5, 49.60, "пач.")
                };

                WriteLine("\nПервый способ:");
                double total1 = 0;
                foreach (Payment p in purchases1)
                {
                    p.Print();
                    total1 += p.Cost;
                }
                WriteLine($"Итого: {total1:F2} руб.");

                // Второй способ
                Payment2[] purchases2 =
                {
                    new Payment2("Молоко", 3, 58.60, "бут."),
                    new Payment2("Йогурт", 5, 38.20, "стак."),
                    new Payment2("Творог", 5, 49.60, "пач.")
                };

                WriteLine("\nВторой способ:");
                double total2 = 0;
                foreach (Payment2 p in purchases2)
                {
                    p.Print();
                    total2 += p.GetCost();
                }
                WriteLine($"Итого: {total2:F2} руб.");
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Отшибка в данных: {ex.Message}");
            }

        }
    }
}