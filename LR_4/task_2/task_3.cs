using System;
using static System.Console;

namespace OOP_2
{
    public class Student
    {
        private string fullName;
        private string group;
        private double averageGrade;
        private double incomePerMember;

        public Student(string fullName, string group, double averageGrade, double incomePerMember)
        {
            this.fullName = fullName;
            this.group = group;
            this.averageGrade = averageGrade;
            this.incomePerMember = incomePerMember;
        }

        public void Display()
        {
            WriteLine($"ФИО: {fullName}");
            WriteLine($"Группа: {group}");
            WriteLine($"Средний балл: {averageGrade:F2}");
            WriteLine($"Доход на члена семьи: {incomePerMember:F2} руб.");
            WriteLine();
        }
    }

    class Task_S
    {
        static void Main(string[] args)
        {
            WriteLine("Список студентов на получение места в общежитии\n");

            Student[] students =
            {
                new Student("Кудинов Кирилл Андреевич", "ИСТ-321", 4.75, 70500),
                new Student("Зуев Кирилл Сергеевич", "ИСТ-322", 4.40, 55200),
                new Student("Чекусов Михаил Евгеньевич", "А-21", 3.90, 51000)
            };

            foreach (Student s in students)
                s.Display();

        }
    }
}