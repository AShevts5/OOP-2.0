using System;
using static System.Console;

namespace OOP_2
{
    public class Call
    {
        private DateTime date;
        private string cityCode;
        private string cityName;
        private int duration;      
        private double tariff;     
        private string phoneNumber;

        public Call(DateTime date, string cityCode, string cityName, int duration, double tariff, string phoneNumber)
        {
            this.date = date;
            this.cityCode = cityCode;
            this.cityName = cityName;
            this.duration = duration;
            this.tariff = tariff;
            this.phoneNumber = phoneNumber;
        }

        public void Display()
        {
            WriteLine($"Дата разговора: {date:dd.MM.yyyy}");
            WriteLine($"Код города: {cityCode}");
            WriteLine($"Город: {cityName}");
            WriteLine($"Время разговора: {duration} мин.");
            WriteLine($"Тариф: {tariff:F2} руб./мин.");
            WriteLine($"Номер абонента: {phoneNumber}");
        }
    }

    class PhoneStationTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Информация о междугородных разговорах\n");

            Call[] calls =
            {
                new Call(new DateTime(2026, 10, 12), "495", "Москва", 12, 3.50, "+7 863 123-45-67"),
                new Call(new DateTime(2026, 10, 14), "812", "Санкт-Петербург", 7, 3.80, "+7 863 234-56-78"),
                new Call(new DateTime(2026, 10, 17), "861", "Краснодар", 25, 2.90, "+7 863 345-67-89")
            };

            foreach (Call c in calls)
                c.Display();

        }
    }
}