using System;
using static System.Console;

namespace OOP
{
    public class Service
    {
        private DateTime _date;
        private string _serviceCode;
        private string _serviceName;
        private decimal _price;
        private int _quantity;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public string ServiceCode
        {
            get => _serviceCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Код услуги не может быть пустым.");
                _serviceCode = value.Trim();
            }
        }

        public string ServiceName
        {
            get => _serviceName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Наименование услуги не может быть пустым.");
                _serviceName = value.Trim();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена услуги не может быть отрицательной.");
                _price = value;
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество услуг не может быть отрицательным.");
                _quantity = value;
            }
        }

        public Service(DateTime date, string serviceCode, string serviceName, 
                       decimal price, int quantity)
        {
            Date = date;
            ServiceCode = serviceCode;
            ServiceName = serviceName;
            Price = price;
            Quantity = quantity;
        }

        public decimal CalculateTotalCost()
        {
            return _price * _quantity;
        }

        public void Display()
        {
            WriteLine("Данные об услуге:");
            WriteLine($"Дата: {Date:dd.MM.yyyy}");
            WriteLine($"Код услуги: {ServiceCode}");
            WriteLine($"Наименование: {ServiceName}");
            WriteLine($"Цена за единицу: {Price:C2}");
            WriteLine($"Количество: {Quantity}");
            WriteLine($"Общая стоимость: {CalculateTotalCost():C2}");
            WriteLine();
        }
    }

    class t4
    {
        static void Main()
        {

            Service service1 = new Service(
                date: new DateTime(2026, 11, 14),
                serviceCode: "SRV-001",
                serviceName: "Техническое обслуживание",
                price: 1500.00m,
                quantity: 3
            );

            Service service2 = new Service(
                date: new DateTime(2026, 11, 14),
                serviceCode: "SRV-002",
                serviceName: "Диагностика оборудования",
                price: 800.50m,
                quantity: 5
            );

            service1.Display();
            service2.Display();

        }
    }
}