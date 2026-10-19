using System;
using static System.Console;

namespace OOP_2
{
    public class BusTrip
    {
        private string number;
        private string busType;
        private string destination;
        private TimeSpan departure;
        private TimeSpan arrival;

        public BusTrip(string number, string busType, string destination, TimeSpan departure, TimeSpan arrival)
        {
            this.number = number;
            this.busType = busType;
            this.destination = destination;
            this.departure = departure;
            this.arrival = arrival;
        }

        public void Display()
        {
            WriteLine($"Номер рейса: {number}");
            WriteLine($"Тип автобуса: {busType}");
            WriteLine($"Пункт назначения: {destination}");
            WriteLine($"Время отправления: {departure:hh\\:mm}");
            WriteLine($"Время прибытия: {arrival:hh\\:mm}");
            WriteLine();
        }
    }

    class BusStationTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Расписание движения автобусов\n");

            BusTrip[] trips =
            {
                new BusTrip("101", "Икарус", "Ростов-на-Дону", new TimeSpan(7, 30, 0), new TimeSpan(9, 0, 0)),
                new BusTrip("215", "ПАЗ", "Новочеркасск", new TimeSpan(10, 15, 0), new TimeSpan(11, 20, 0)),
                new BusTrip("340", "Икарус", "Краснодар", new TimeSpan(14, 0, 0), new TimeSpan(19, 45, 0))
            };

            foreach (BusTrip t in trips)
                t.Display();

        }
    }
}