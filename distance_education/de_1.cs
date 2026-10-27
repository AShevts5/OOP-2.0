using System;
using static System.Console;

namespace OOP
{
    public class Student
    {
        public string fio { get; private set; }
        public string num_zach { get; private set; }
        public string num_group { get; private set; }

        public Student()
        {
            fio = "Не указано";
            num_zach = "000000";
            num_group = "Не указана";
        }

        public Student(string fio, string num_zach, string num_group)
        {
            if (string.IsNullOrWhiteSpace(fio))
                throw new ArgumentException("Обшибочка, ФИО не может быть пустым");
            if (string.IsNullOrWhiteSpace(num_zach))
                throw new ArgumentException("Обшибочка, номер зачётки не может быть пустым");
            if (string.IsNullOrWhiteSpace(num_group))
                throw new ArgumentException("Обшибочка, номер группы не может быть пустым");

            this.fio = fio;
            this.num_zach = num_zach;
            this.num_group = num_group;
        }

        public void ChangeGroup(string newGroupNumber)
        {
            if (string.IsNullOrWhiteSpace(newGroupNumber))
                throw new ArgumentException("Бро, номер группы не может быть пустым");
            num_group = newGroupNumber;
        }

        public override string ToString()
        {
            return fio;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
                return num_zach == other.num_zach;
            return false;
        }

        // важно переопределить и GetHashCode
        public override int GetHashCode()
        {
            return num_zach.GetHashCode();
        }
    }

    class de_1
    {
        static void Main()
        {
            // тестирование конструктора без параметров
            Student s0 = new Student();
            WriteLine($"Конструктор без параметров:");
            WriteLine($" ФИО: {s0.fio}, зачётка: {s0.num_zach}, группа: {s0.num_group}\n");

            // тестирование конструктора с параметрами 
            Student[] students =
            {
                new Student("Шевцова Анна Владимировна", "555555", "ПИ-321"),
                new Student("Жуков Леонид Николаевич", "123455", "ПРИ-321"),
                new Student("Степачков Даниил Алексеевич", "123456", "ПИ-321")
            };

            WriteLine("Конструктор с параметрами:");
            for (int i = 0; i < students.Length; i++)
            {
                WriteLine($"s{i + 1}: {students[i].fio}, {students[i].num_zach}, {students[i].num_group}");
            }
            WriteLine();

            // Изменение номера группы 
            WriteLine($"Группа s2 до: {students[1].num_group}");
            students[1].ChangeGroup("ПИ-321");
            WriteLine($"Группа s2 после: {students[1].num_group}\n");

            WriteLine("ToString():");
            for (int i = 0; i < students.Length; i++)
            {
                WriteLine($" s{i + 1}.ToString(): {students[i]}");
            }
            WriteLine();

            Student s1 = students[0];
            Student s2 = students[1];
            Student c = new Student("Жуков ЛН", "555555", "ПИ-322"); // для проверки equals

            WriteLine("Equals():");
            WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
            WriteLine($"s1.Equals(copy): {s1.Equals(c)}");
            WriteLine($"s1.Equals(s1): {s1.Equals(s1)}");
            WriteLine($"s1.Equals(null): {s1.Equals(null)}");
            WriteLine($"s1.Equals(\"555555\"): {s1.Equals("555555")}\n");

            // Обработка некорректных данных, которые заполняем сразу в коде
            WriteLine("Братишка, некорректные данные:");
            try
            {
                s1.ChangeGroup("");
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка при смене группы: {ex.Message}");
            }
            try
            {
                Student bad = new Student("", "111", "ПИ-21");
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка в конструкторе: {ex.Message}");
            }
        }
    }
}