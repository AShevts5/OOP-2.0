using System;
using static System.Console;

namespace OOP_2
{
    public class StaffMember
    {
        private string fullName;
        private int department;  
        private string position;
        private int experience;   
        public StaffMember(string fullName, int department, string position, int experience)
        {
            this.fullName = fullName;
            this.department = department;
            this.position = position;
            this.experience = experience;
        }

        public void Display()
        {
            WriteLine($"ФИО: {fullName}");
            WriteLine($"Номер отдела: {department}");
            WriteLine($"Должность: {position}");
            WriteLine($"Стаж работы: {experience} лет");
            WriteLine();
        }
    }

    class StaffTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Информация о сотрудниках\n");

            StaffMember[] staff =
            {
                new StaffMember("Шевцова Анна Владимировна", 1, "Backend-разработчик", 3),
                new StaffMember("Кудинов Кирилл Андреевич", 2, "Frontend-разработчик", 2),
                new StaffMember("Зуев Кирилл Сергеевич", 1, "DevOps-инженер", 1)
            };

            foreach (StaffMember s in staff)
                s.Display();

        }
    }
}