using System;
using static System.Console;
using static System.Math;
namespace OOP
{
    public abstract class Figure
    {
        public double X { get; private set; }

        public Figure(double x)
        {
            if (x <= 0)
                throw new ArgumentException("Обшибочка, размер фигуры должен быть больше нуля");
            X = x;
        }

        public abstract double Area();
    }

    public class Square : Figure
    {
        public Square(double x) : base(x) { }

        public override double Area()
        {
            return X * X;
        }

        public void PrintArea()
        {
            WriteLine($"Площадь квадрата со стороной {X}: {Area():F2}");
        }
    }

    public class Circle : Figure
    {
        public Circle(double x) : base(x) { }

        public override double Area()
        {
            return PI * X * X;
        }

        public void PrintArea()
        {
            WriteLine($"Площадь круга с радиусом {X}: {Area():F2}");
        }
    }

    class de_2
    {
        static void Main()
        {
            // проверка методов дочерних классов
            // тестирование квадрата
            Square sq = new Square(4);
            sq.PrintArea();

            // тестирование окружности
            Circle c = new Circle(3);
            c.PrintArea();
            WriteLine();

            // для проверки уже родттельского класса
            Figure[] figures =
            {
                new Square(2),
                new Square(5.5),
                new Circle(1),
                new Circle(2.5)
            };

            for (int i = 0; i < figures.Length; i++)
            {
                WriteLine($"{i + 1}) {figures[i].GetType().Name}, X = {figures[i].X}, площадь = {figures[i].Area():F2}");
            }
            WriteLine();


            // пример обработки некорректных данных
            WriteLine("Братишка, некорректные данные");
            try
            {
                Square bad = new Square(-2);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка при создании квадрата: {ex.Message}");
            }
            try
            {
                Circle bad = new Circle(0);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка при создании окружности: {ex.Message}");
            }
        }
    }
}