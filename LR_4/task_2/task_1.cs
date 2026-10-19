using System;
using static System.Console;

namespace OOP_2
{
    public class Client
    {
        // поля
        private string fullName;
        private string address;
        private double discount;   

        public Client(string fullName, string address, double discount)
        {
            if (discount < 0 || discount > 100)
                throw new ArgumentException("Скидка должна быть от 0 до 100%");

            this.fullName = fullName;
            this.address = address;
            this.discount = discount;
        }

        public void Display()
        {
            WriteLine($"ФИО: {fullName}");
            WriteLine($"Адрес: {address}");
            WriteLine($"Скидка: {discount}%");
            WriteLine();
        }

    }

    class ClientsTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Список постоянных клиентов магазина\n");

            try
            {
                Client[] clients =
                {
                    new Client("Шевцова Анна Владимировна", "г. Ростов-на-Дону, ул. Садовая, д. 12, кв. 5", 5),
                    new Client("Жуков Леонид Николаевич", "г. Ростов-на-Дону, пр. Ворошиловский, д. 40, кв. 18", 10),
                    new Client("Кудинов Кирилл Андреевич", "г. Аксай, ул. Платова, д. 3", 15)
                };

                foreach (Client c in clients)
                    c.Display();

            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в данных: {ex.Message}");
            }

        }
    }
}