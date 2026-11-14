using System;
using static System.Console;

namespace OOP
{
    public class ZHKH
    {
        private string _accountNumber;
        private decimal _gasPayment;
        private decimal _trashPayment;
        private decimal _waterPayment;

        public string AccountNumber
        {
            get => _accountNumber;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Лицевой счёт не может быть пустым.");
                _accountNumber = value.Trim();
            }
        }

        public decimal GasPayment
        {
            get => _gasPayment;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Оплата за газ не может быть отрицательной.");
                _gasPayment = value;
            }
        }

        public decimal TrashPayment
        {
            get => _trashPayment;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Оплата за мусор не может быть отрицательной.");
                _trashPayment = value;
            }
        }

        public decimal WaterPayment
        {
            get => _waterPayment;
            init
            {
                if (value < 0)
                    throw new ArgumentException("Оплата за воду не может быть отрицательной.");
                _waterPayment = value;
            }
        }

        public ZHKH(string accountNumber, decimal gasPayment, 
                   decimal trashPayment, decimal waterPayment)
        {
            AccountNumber = accountNumber;
            GasPayment = gasPayment;
            TrashPayment = trashPayment;
            WaterPayment = waterPayment;
        }

        public decimal CalculateTotal()
        {
            return _gasPayment + _trashPayment + _waterPayment;
        }

        public void Display()
        {
            WriteLine($"Лицевой счёт: {AccountNumber}");
            WriteLine($"Оплата за газ: {GasPayment:C2}");
            WriteLine($"Оплата за мусор: {TrashPayment:C2}");
            WriteLine($"Оплата за воду: {WaterPayment:C2}");
            WriteLine($"Общая стоимость: {CalculateTotal():C2}");
            WriteLine();
        }
    }

    class t2
    {
        static void Main()
        {

            ZHKH account1 = new ZHKH(
                accountNumber: "123456789",
                gasPayment: 1500.50m,
                trashPayment: 250.00m,
                waterPayment: 800.75m
            );

            ZHKH account2 = new ZHKH(
                accountNumber: "987654321",
                gasPayment: 2200.00m,
                trashPayment: 300.00m,
                waterPayment: 1100.25m
            );

            account1.Display();
            account2.Display();

        }
    }
}