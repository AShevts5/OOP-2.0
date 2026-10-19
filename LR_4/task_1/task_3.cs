using System;
using static System.Console;

namespace OOP_2
{
    // Первый способ: свойства с аксессорами 
    public class Payment
    {
        private string name;
        private double quantity;
        private double price;
        private string unit;

        public Payment(string name, double quantity, double price, string unit = "шт.")
        {
            Name = name;
            Quantity = quantity;   
            Price = price;
            Unit = unit;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество не может быть отрицательным");
                quantity = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена не может быть отрицательной");
                price = value;
            }
        }

        public string Unit   
        {
            get { return unit; }
            set { unit = value; }
        }

        public double Cost
        {
            get { return Math.Round(quantity * price, 2); }
        }

        public void Print()
        {
            WriteLine($"{Name}: {Quantity} {Unit} × {Price:F2} руб. = {Cost:F2} руб.");
        }
    }

    // Второй способ: методы доступа без аксессоров 
    public class Payment2
    {
        private string name;
        private double quantity;
        private double price;
        private string unit;

        public Payment2(string name, double quantity, double price, string unit = "шт.")
        {
            SetName(name);
            SetQuantity(quantity);
            SetPrice(price);
            SetUnit(unit);
        }

        public void SetName(string value) { name = value; }
        public string GetName() { return name; }

        public void SetQuantity(double value)
        {
            if (value < 0)
                throw new ArgumentException("Количество не может быть отрицательным");
            quantity = value;
        }
        public double GetQuantity() { return quantity; }

        public void SetPrice(double value)
        {
            if (value < 0)
                throw new ArgumentException("Цена не может быть отрицательной");
            price = value;
        }
        public double GetPrice() { return price; }

        public void SetUnit(string value) { unit = value; }
        public string GetUnit() { return unit; }

        public double GetCost() { return Math.Round(quantity * price, 2); }

        public void Print()
        {
            WriteLine($"{GetName()}: {GetQuantity()} {GetUnit()} × {GetPrice():F2} руб. = {GetCost():F2} руб.");
        }
    }

    class Task_3
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            double quantity = rnd.Next(1, 11);                          
            double price = Math.Round(rnd.NextDouble() * 990 + 10, 2);  

            try
            {
                Payment p1 = new Payment("Стоимость товара", quantity, price);
                Write("Первый способ: ");
                p1.Print();

                Payment2 p2 = new Payment2("Стоимость товара", quantity, price);
                Write("Второй способ: ");
                p2.Print();
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в данных: {ex.Message}");
            }

        }
    }
}