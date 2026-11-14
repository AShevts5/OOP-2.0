using System;
using static System.Console;

namespace OOP
{
    public class Salary
    {
        private int _year;
        private int _month;
        private string _employeeId;
        private decimal _accrued;
        private decimal _withheld;

        public int Year
        {
            get => _year;
            init
            {
                if (value < 2000 || value > 2100)
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

        public string EmployeeId
        {
            get => _employeeId;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Табельный номер не может быть пустым.");
                _employeeId = value.Trim();
            }
        }

        public decimal Accrued
        {
            get => _accrued;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Начисленная сумма не может быть отрицательной.");
                _accrued = value;
            }
        }

        public decimal Withheld
        {
            get => _withheld;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Удержанная сумма не может быть отрицательной.");
                if (value > _accrued)
                    throw new ArgumentException("Удержания не могут превышать начисленную сумму.");
                _withheld = value;
            }
        }

        public Salary(int year, int month, string employeeId, 
                           decimal accrued, decimal withheld)
        {
            Year = year;
            Month = month;
            EmployeeId = employeeId;
            Accrued = accrued;
            Withheld = withheld;
        }

        public decimal CalculatePay()
        {
            return _accrued - _withheld;
        }

        public void Display()
        {
            WriteLine($"Период: {Month:D2}.{Year}");
            WriteLine($"Табельный номер: {EmployeeId}");
            WriteLine($"Начислено: {Accrued:C2}");
            WriteLine($"Удержано: {Withheld:C2}");
            WriteLine($"К выдаче: {CalculatePay():C2}");
            WriteLine();
        }
    }

    class t5
    {
        static void Main()
        {

            Salary salary1 = new Salary(
                year: 2026,
                month: 11,
                employeeId: "58870",
                accrued: 75000.00m,
                withheld: 9750.00m
            );

            Salary salary2 = new Salary(
                year: 2026,
                month: 11,
                employeeId: "26546",
                accrued: 52000.00m,
                withheld: 6760.00m
            );

            salary1.Display();
            salary2.Display();

         }
    }
}