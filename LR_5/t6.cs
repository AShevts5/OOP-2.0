using System;
using static System.Console;

namespace OOP
{
    public class Warehouse
    {
        private DateTime _date;
        private string _productName;
        private decimal _received;
        private decimal _issued;

        public DateTime Date
        {
            get => _date;
            init => _date = value;
        }

        public string ProductName
        {
            get => _productName;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Наименование товара не может быть пустым.");
                _productName = value.Trim();
            }
        }

        public decimal Received
        {
            get => _received;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Количество полученного товара не может быть отрицательным.");
                _received = value;
            }
        }

        public decimal Issued
        {
            get => _issued;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Количество выделенного товара не может быть отрицательным.");
                if (value > _received)
                    throw new ArgumentException("Выделенное не может превышать полученное.");
                _issued = value;
            }
        }

        public Warehouse(DateTime date, string productName, 
                              decimal received, decimal issued)
        {
            Date = date;
            ProductName = productName;
            Received = received;
            Issued = issued;
        }

        public decimal CalculateFinal()
        {
            return _received - _issued;
        }

        public void Display()
        {
            WriteLine($"Дата: {Date:dd.MM.yyyy}");
            WriteLine($"Наименование товара: {ProductName}");
            WriteLine($"Получено: {Received:F2} кг");
            WriteLine($"Выделено: {Issued:F2} кг");
            WriteLine($"Остаток на дату: {CalculateFinal():F2} кг");
            WriteLine();
        }
    }

    class t6
    {
        static void Main()
        {

            Warehouse record1 = new Warehouse(
                date: new DateTime(2026, 11, 14),
                productName: "Цемент М500",
                received: 500.00m,
                issued: 150.50m
            );

            Warehouse record2 = new Warehouse(
                date: new DateTime(2026, 11, 14),
                productName: "Кирпич красный",
                received: 1000.00m,
                issued: 400.00m
            );

            record1.Display();
            record2.Display();

        }
    }
}