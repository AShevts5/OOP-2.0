using System;
using static System.Console;

namespace OOP
{
    public class BankAccount
    {
        public string num_schet { get; set; }
        public string fio { get; set; }

        public decimal balance { get; private set; }
        public DateTime? last_date { get; private set; }   

        public void Deposit(decimal sum)
        {
            if (sum <= 0)
                throw new ArgumentException("Обшибочка, сумма зачисления должна быть больше нуля");
            balance += sum;
            last_date = DateTime.Now;
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= 0)
                throw new ArgumentException("Обшибочка, сумма списания должна быть больше нуля");
            if (sum > balance)
                throw new ArgumentException("Бро, на счёте недостаточно средств");
            balance -= sum;
            last_date = DateTime.Now;
        }

        public void Input()
        {
            Write("Введите номер счёта: ");
            string num = ReadLine();
            Write("Введите ФИО клиента: ");
            string name = ReadLine();

            if (string.IsNullOrWhiteSpace(num))
                throw new ArgumentException("Обшибочка, номер счёта не может быть пустым");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Обшибочка, ФИО не может быть пустым");

            num_schet = num;
            fio = name;
        }

        public void Print()
        {
            WriteLine($"Счёт: {num_schet}");
            WriteLine($"Клиент: {fio}");
            WriteLine($"Баланс: {balance} руб.");
            if (last_date == null)
                WriteLine(" Последняя операция: операций не было");
            else
                WriteLine($" Последняя операция: {last_date:dd.MM.yyyy HH:mm:ss}");
            WriteLine();
        }

        public override string ToString()
        {
            return fio;
        }

        public override bool Equals(object obj)
        {
            if (obj is BankAccount other)
                return num_schet == other.num_schet;
            return false;
        }

        // нада переопределить еще GetHashCode
        public override int GetHashCode()
        {
            return num_schet.GetHashCode();
        }
    }

    class de_3
    {
        static void Main()
        {
            BankAccount a1 = new BankAccount { num_schet = "40817001", fio = "Шевцова Анна Владимировна" };
            BankAccount a2 = new BankAccount { num_schet = "40817002", fio = "Кудинов Кирилл Андреевич" };
            BankAccount c = new BankAccount { num_schet = "40817001", fio = "Шевцова А.В." }; 

            WriteLine("Счёт сразу после создания:");
            a1.Print();

            // зачисление
            a1.Deposit(70000);
            WriteLine("После зачисления 70000:");
            a1.Print();

            // списание
            a1.Withdraw(30);
            WriteLine("После списания 30:");
            a1.Print();

            WriteLine($"a1.ToString(): {a1}");
            WriteLine($"a2.ToString(): {a2}\n");

            WriteLine($"a1.Equals(a2): {a1.Equals(a2)}");
            WriteLine($"a1.Equals(copy): {a1.Equals(c)}");
            WriteLine($"a1.Equals(null): {a1.Equals(null)}");
            WriteLine($"a1.Equals(\"40817001\"): {a1.Equals("40817001")}\n");

            // пример обработки некорректных данных
            WriteLine("Братишка, некорректные данные");
            try
            {
                a2.Withdraw(500);   
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка при списании: {ex.Message}");
            }
            try
            {
                a1.Deposit(-100);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка при зачислении: {ex.Message}");
            }
            WriteLine();

            WriteLine("Ввод нового счёта:");
            BankAccount a3 = new BankAccount();
            try
            {
                a3.Input();
                a3.Deposit(1000);
                WriteLine("\nДанные введённого счёта:");
                a3.Print();
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка ввода: {ex.Message}");
            }
        }
    }
}