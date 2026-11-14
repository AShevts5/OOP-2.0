using System;
using static System.Console;

namespace OOP
{
    public class ATC
    {
        private int _year;
        private int _month;
        private decimal _totalCallTime;
        private decimal _tariff;

        public int Year
        {
            get => _year;
            init
            {
                if (value < 2000 || value > 2026)
                    throw new ArgumentException("Год должен быть в диапазоне 2000-2026.");
                _year = value;
            }
        }

        public int Month
        {
            get => _month;
            init
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Месяц должен быть от 1 до 12.");
                _month = value;
            }
        }

        public decimal TotalCallTime
        {
            get => _totalCallTime;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Общее время разговоров не может быть отрицательным.");
                _totalCallTime = value;
            }
        }

        public decimal Tariff
        {
            get => _tariff;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Тариф не может быть отрицательным.");
                _tariff = value;
            }
        }

        public ATC(int year, int month, decimal totalCallTime, decimal tariff)
        {
            Year = year;
            Month = month;
            TotalCallTime = totalCallTime;
            Tariff = tariff;
        }

        public decimal CalculateCost()
        {
            return _totalCallTime * _tariff;
        }

        public void Display()
        {
            WriteLine($"Период: {Month:D2}.{Year}");
            WriteLine($"Общее время разговоров: {TotalCallTime:F2} мин.");
            WriteLine($"Тариф: {Tariff:C2}/мин.");
            WriteLine($"Стоимость разговоров: {CalculateCost():C2}");
            WriteLine();
        }
    }

    class t7
    {
        static void Main()
        {

            ATC bill1 = new ATC(
                year: 2026,
                month: 11,
                totalCallTime: 245.50m,
                tariff: 2.50m
            );

            ATC bill2 = new ATC(
                year: 2026,
                month: 11,
                totalCallTime: 120.00m,
                tariff: 3.00m
            );

            bill1.Display();
            bill2.Display();

        }
    }
}