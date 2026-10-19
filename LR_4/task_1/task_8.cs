using System;
using static System.Console;

namespace OOP_2
{
    class Task_8
    {
        static void Main(string[] args)
        {
            const double discount = 0.10;   

            try
            {
                // Первый способ
                Payment pate1 = new Payment("Паштет печёночный", 5, 48.50, "бан.");
                Payment fish1 = new Payment("Консервы рыбные", 5, 82.20, "бан.");
                Payment cookies1 = new Payment("Печенье (со скидкой 10%)", 5, 70.00, "пач.");

                cookies1.Price = Math.Round(cookies1.Price * (1 - discount), 2);

                Payment[] purchases1 = { pate1, fish1, cookies1 };

                WriteLine("\nПервый способ:");
                double total1 = 0;
                foreach (Payment p in purchases1)
                {
                    p.Print();
                    total1 += p.Cost;
                }
                WriteLine($"Итого: {total1:F2} руб.");

                // Второй способ
                Payment2 pate2 = new Payment2("Паштет печёночный", 5, 48.50, "бан.");
                Payment2 fish2 = new Payment2("Консервы рыбные", 5, 82.20, "бан.");
                Payment2 cookies2 = new Payment2("Печенье (со скидкой 10%)", 5, 70.00, "пач.");

                cookies2.SetPrice(Math.Round(cookies2.GetPrice() * (1 - discount), 2));

                Payment2[] purchases2 = { pate2, fish2, cookies2 };

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
                WriteLine($"Ошибка в данных: {ex.Message}");
            }

        }
    }
}