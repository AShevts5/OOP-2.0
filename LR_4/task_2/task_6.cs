using System;
using static System.Console;

namespace OOP_2
{
    public class Employee
    {
        private string fullName;
        private string personnelNumber;
        private int hoursWorked;
        private double hourlyRate;

        public Employee(string fullName, string personnelNumber, int hoursWorked, double hourlyRate)
        {
            this.fullName = fullName;
            this.personnelNumber = personnelNumber;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }

        public void Display()
        {
            WriteLine($"ФИО: {fullName}");
            WriteLine($"Табельный номер: {personnelNumber}");
            WriteLine($"Отработано часов за месяц: {hoursWorked} ч.");
            WriteLine($"Почасовой тариф: {hourlyRate:F2} руб./ч.");
            WriteLine();
        }
    }

    class EmployeesTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Информация о сотрудниках фирмы\n");

            Employee[] employees =
            {
                new Employee("Шевцова Анна Владимировна", "000127", 168, 5000.00),
                new Employee("Камалин Игорь Владимирович", "000245", 152, 3520.00),
                new Employee("Зуев Кирилл Сергеевич", "000318", 176, 3090.00)
            };

            foreach (Employee e in employees)
                e.Display();

        }
    }
}