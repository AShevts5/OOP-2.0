using System;
using static System.Console;
using static System.Math;

namespace OOP
{
    public class Vector
    {
        public double x { get; private set; }
        public double y { get; private set; }

        public Vector()
        {
            x = 0;
            y = 0;
        }

        public Vector(double x, double y)
        {
            if (double.IsNaN(x) || double.IsNaN(y) || double.IsInfinity(x) || double.IsInfinity(y))
                throw new ArgumentException("Ошибочка, координаты должны быть обычными числами");

            this.x = x;
            this.y = y;
        }

        public double Length()
        {
            return Sqrt(x * x + y * y);
        }

        public override string ToString()
        {
            return $"Координаты вектора: ({x}; {y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector other)
                return Round(x, 6) == Round(other.x, 6) && Round(y, 6) == Round(other.y, 6);
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Round(x, 6), Round(y, 6));
        }
    }

    class de_5
    {
        static void Main()
        {
            // тестирование конструктора без параметров
            Vector v0 = new Vector();
            WriteLine($"Конструктор без параметров: {v0}, длина = {v0.Length()}\n");

            // тестирование конструктора с параметрами
            Vector[] vectors =
            {
                new Vector(3, 4),
                new Vector(-1.5, 2),
                new Vector(1, 1)
            };

            WriteLine("Конструктор с параметрами:");
            for (int i = 0; i < vectors.Length; i++)
            {
                WriteLine($" v{i + 1} = {vectors[i]}, длина = {vectors[i].Length():F3}");
            }
            WriteLine();

            // Equals()
            Vector v1 = vectors[0];
            Vector v2 = vectors[1];
            Vector c = new Vector(3, 4);         
            Vector a = new Vector(0.1 + 0.2, 1);     
            Vector b = new Vector(0.3, 1);

            WriteLine("Equals():");
            WriteLine($"v1.Equals(v2): {v1.Equals(v2)}");
            WriteLine($"v1.Equals(copy): {v1.Equals(c)}");
            WriteLine($"v1.Equals(null): {v1.Equals(null)}");
            WriteLine($"v1.Equals(\"(3; 4)\"): {v1.Equals("(3; 4)")}\n");

            // обработка некорректных данных
            WriteLine("Братишка, некорректные данные");
            try
            {
                Vector bad = new Vector(double.NaN, 1);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в конструкторе: {ex.Message}");
            }
        }
    }
}