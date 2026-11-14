using System;
using static System.Console;

namespace OOP
{
    public class Cinema
    {
        private DateTime _date;
        private TimeSpan _time;
        private int _ticketsSold;
        private decimal _ticketPrice;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public TimeSpan Time
        {
            get => _time;
            set => _time = value;
        }

        public int TicketsSold
        {
            get => _ticketsSold;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество проданных билетов не может быть отрицательным.");
                _ticketsSold = value;
            }
        }

        public decimal TicketPrice
        {
            get => _ticketPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Цена билета не может быть отрицательной.");
                _ticketPrice = value;
            }
        }

        public Cinema(DateTime date, TimeSpan time, int ticketsSold, decimal ticketPrice)
        {
            Date = date;
            Time = time;
            TicketsSold = ticketsSold;
            TicketPrice = ticketPrice;
        }

        public decimal CalculateTotal()
        {
            return _ticketsSold * _ticketPrice;
        }

        public void Display()
        {
            WriteLine("Данные сеанса:");
            WriteLine($"Дата: {Date:dd.MM.yyyy}");
            WriteLine($"Время сеанса: {Time:hh\\:mm}");
            WriteLine($"Количество проданных билетов: {TicketsSold}");
            WriteLine($"Цена билета: {TicketPrice:C2}");
            WriteLine($"Стоимость проданных билетов: {CalculateTotal():C2}");
            WriteLine();
        }
    }

    class t3
    {
        static void Main()
        {

            Cinema session1 = new Cinema(
                date: new DateTime(2026, 11, 14),
                time: new TimeSpan(18, 30, 0),
                ticketsSold: 150,
                ticketPrice: 350.00m
            );

            Cinema session2 = new Cinema(
                date: new DateTime(2026, 11, 14),
                time: new TimeSpan(21, 00, 0),
                ticketsSold: 200,
                ticketPrice: 450.50m
            );

            session1.Display();
            session2.Display();

        }
    }
}