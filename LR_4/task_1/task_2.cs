using System;
using static System.Console;

namespace OOP_2
{
    class Task_2
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double a = rnd.Next(-10, 11);
            double b = rnd.Next(-10, 11);

            Task12 e1 = new Task12(a, b, '*');
            Task121 e2 = new Task121(a, b, '*');

            WriteLine($"a = {a}, b = {b}");
            WriteLine($"Первый способ: y = {e1.Y}");
            WriteLine($"Второй способ: y = {e2.GetY()}");

        }
    }
}