using System;
using static System.Console;

namespace OOP_2
{
    public class Product
    {
        private string name;
        private int quantity;
        private double price;
        private DateTime arrivalDate;

        public Product(string name, int quantity, double price, DateTime arrivalDate)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.arrivalDate = arrivalDate;
        }

        public void Display()
        {
            WriteLine($"Наименование: {name}");
            WriteLine($"Количество: {quantity} шт.");
            WriteLine($"Цена единицы: {price:F2} руб.");
            WriteLine($"Дата поступления: {arrivalDate:dd.MM.yyyy}");
            WriteLine();
        }
    }

    class Task_2t
    {
        static void Main1(string[] args)
        {
            WriteLine("Список товаров на складе\n");

            Product[] products =
            {
                new Product("Молоко", 120, 58.60, new DateTime(2026, 10, 15)),
                new Product("Творог", 80, 49.60, new DateTime(2026, 10, 16)),
                new Product("Йогурт", 200, 38.20, new DateTime(2026, 10, 17))
            };

            foreach (Product p in products)
                p.Display();

        }
    }
}