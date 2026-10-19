using System;
using static System.Math;
using static System.Console;

namespace OOP_2
{
    // первый способ: свойства с аксессорами get и set
    public class Task12
    {
        private double a;
        private double b;
        private readonly char operation;

        public Task12(double a, double b, char operation)
        {
            if (operation != '-' && operation != '*')
                throw new ArgumentException("Допустимые операции на данный момент: '-' и '*' ");

            this.a = a;
            this.b = b;
            this.operation = operation;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public char Operation
        {
            get { return operation; }
        }

        public double Y
        {
            get { return Calculate(); }
        }

        private double Calculate()
        {
            switch (operation)
            {
                case '-': return Pow(a - b, 2);
                case '*': return Pow(a * b, 2);
                default: throw new InvalidOperationException("Шо-то Вы операцию попутали :)");
            }
        }
    }

    // второй способ: методы доступа без аксессоров 
    public class Task121
    {
        private double a;
        private double b;
        private readonly char operation;

        public Task121(double a, double b, char operation)
        {
            if (operation != '-' && operation != '*')
                throw new ArgumentException("Допустимые операции на данный момент: '-' и '*' ");

            this.a = a;
            this.b = b;
            this.operation = operation;
        }

        public void SetA(double value) { a = value; }
        public double GetA() { return a; }

        public void SetB(double value) { b = value; }
        public double GetB() { return b; }

        public char GetOperation() { return operation; }

        public double GetY() { return Calculate(); }

        private double Calculate()
        {
            switch (operation)
            {
                case '-': return Pow(a - b, 2);
                case '*': return Pow(a * b, 2);
                default: throw new InvalidOperationException("Шо-то Вы операцию попутали :)");
            }
        }
    }

    class Task_1
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double a = rnd.Next(-10, 11);
            double b = rnd.Next(-10, 11);

            Task12 e1 = new Task12(a, b, '-');
            Task121 e2 = new Task121(a, b, '-');

            WriteLine($"a = {a}, b = {b}");
            WriteLine($"Первый способ: y = {e1.Y}");
            WriteLine($"Второй способ: y = {e2.GetY()}");

        }
    }
}