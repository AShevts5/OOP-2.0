using System;
using static System.Console;

namespace OOP_2
{
    class Task_4
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double kwh = rnd.Next(100, 401);
            double tariff = Math.Round(rnd.NextDouble() * 4 + 5, 2);

            Payment e1 = new Payment("Электроснабжение", kwh, tariff, "кВт/ч");
            Write("Первый способ: ");
            e1.Print();

            Payment2 e2 = new Payment2("Электроснабжение", kwh, tariff, "кВт/ч");
            Write("Второй способ: ");
            e2.Print();

        }
    }
}