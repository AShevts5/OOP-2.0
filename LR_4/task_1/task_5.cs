using System;
using static System.Console;

namespace OOP_2
{
    class Task_5
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double volume = rnd.Next(10, 101);
            double price = Math.Round(rnd.NextDouble() * 3 + 7, 2);

            Payment g1 = new Payment("Природный газ", volume, price, "м^3");
            Write("Первый способ: ");
            g1.Print();

            Payment2 g2 = new Payment2("Природный газ", volume, price, "м^3");
            Write("Второй способ: ");
            g2.Print();

        }
    }
}