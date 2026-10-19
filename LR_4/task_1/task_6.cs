using System;
using static System.Console;

namespace OOP_2
{
    class Task_6
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double gasVolume = rnd.Next(10, 101);
            double gasPrice = Math.Round(rnd.NextDouble() * 3 + 7, 2);
            double waterVolume = rnd.Next(3, 16);
            double waterPrice = Math.Round(rnd.NextDouble() * 30 + 40, 2);
            double kwh = rnd.Next(100, 401);
            double tariff = Math.Round(rnd.NextDouble() * 4 + 5, 2);

            // Первый способ
            Payment[] payments1 =
            {
                new Payment("Природный газ", gasVolume, gasPrice, "м^3"),
                new Payment("Водоснабжение", waterVolume, waterPrice, "м^3"),
                new Payment("Электроснабжение", kwh, tariff, "кВт/ч")
            };

            WriteLine("\nПервый способ:");
            double total1 = 0;
            foreach (Payment p in payments1)
            {
                p.Print();
                total1 += p.Cost;
            }
            WriteLine($"Итого: {total1:F2} руб.");

            // Второй способ
            Payment2[] payments2 =
            {
                new Payment2("Природный газ", gasVolume, gasPrice, "м^3"),
                new Payment2("Водоснабжение", waterVolume, waterPrice, "м^3"),
                new Payment2("Электроснабжение", kwh, tariff, "кВт/ч")
            };

            WriteLine("\nВторой способ:");
            double total2 = 0;
            foreach (Payment2 p in payments2)
            {
                p.Print();
                total2 += p.GetCost();
            }
            WriteLine($"Итого: {total2:F2} руб.");

        }
    }
}