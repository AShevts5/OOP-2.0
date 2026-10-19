using System;
using static System.Console;

namespace OOP_2
{
    public class FactoryProduct
    {
        private string name;
        private int quantity;
        private int workNumber; // номер цеха

        public FactoryProduct(string name, int quantity, int workNumber)
        {
            this.name = name;
            this.quantity = quantity;
            this.workNumber = workNumber;
        }

        public void Display()
        {
            WriteLine($"Наименование: {name}");
            WriteLine($"Количество: {quantity} шт.");
            WriteLine($"Номер цеха: {workNumber}");
            WriteLine();
        }
    }

    class FactoryTask1
    {
        static void Main1(string[] args)
        {
            WriteLine("Сведения о выпущенной продукции\n");

            FactoryProduct[] products =
            {
                new FactoryProduct("Болт М10", 5000, 1),
                new FactoryProduct("Гайка М10", 4800, 1),
                new FactoryProduct("Подшипник 6205", 1200, 2)
            };

            foreach (FactoryProduct p in products)
                p.Display();

        }
    }
}