using System;
using static System.Console;

namespace OOP_2
{
    // Первый способ: свойства с аксессорами
    public class Salary
    {
        public const double TaxRate = 0.13;   

        private string employee = "";
        private double accrued;
        private double other;

        public Salary(string employee, double accrued, double other = 0)
        {
            Employee = employee;
            Accrued = accrued;
            Other = other;
        }

        public string Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public double Accrued
        {
            get { return accrued; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Зарплата не может быть отрицательной");
                accrued = value;
            }
        }

        public double Other
        {
            get { return other; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Удержания не могут быть отрицательными");
                other = value;
            }
        }

        public double Tax
        {
            get { return Math.Round(accrued * TaxRate, 2); }
        }

        public double NetSalary
        {
            get { return Math.Round(accrued - Tax - other, 2); }
        }
    }

    // Второй способ: методы доступа без аксессоров
    public class Salary2
    {
        public const double TaxRate = 0.13;

        private string employee = "";
        private double accrued;
        private double other;

        public Salary2(string employee, double accrued, double other = 0)
        {
            SetEmployee(employee);
            SetAccrued(accrued);
            SetOther(other);
        }

        public void SetEmployee(string value) { employee = value; }
        public string GetEmployee() { return employee; }

        public void SetAccrued(double value)
        {
            if (value < 0)
                throw new ArgumentException("Зарплата не может быть отрицательной))");
            accrued = value;
        }
        public double GetAccrued() { return accrued; }

        public void SetOther(double value)
        {
            if (value < 0)
                throw new ArgumentException("Удержания не могут быть отрицательными");
            other = value;
        }
        public double GetOther() { return other; }

        public double GetTax() { return Math.Round(accrued * TaxRate, 2); }

        public double GetNetSalary() { return Math.Round(accrued - GetTax() - other, 2); }
    }

    class Task_9
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double accrued = rnd.Next(40000, 150001);

            try
            {
                Salary s1 = new Salary("Шевцова А. В.", accrued);
                WriteLine("\nПервый способ:");
                WriteLine($"Сотрудник: {s1.Employee}");
                WriteLine($"Начислено: {s1.Accrued:F2} руб.");
                WriteLine($"Налог 13%: {s1.Tax:F2} руб.");

                Salary2 s2 = new Salary2("Жуков Л. Н.", accrued);
                WriteLine("\nВторой способ:");
                WriteLine($"Сотрудник: {s2.GetEmployee()}");
                WriteLine($"Начислено: {s2.GetAccrued():F2} руб.");
                WriteLine($"Налог 13%: {s2.GetTax():F2} руб.");
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в данных: {ex.Message}");
            }

        }
    }
}