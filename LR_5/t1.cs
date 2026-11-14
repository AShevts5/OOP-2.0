using System;
using static System.Console;

namespace OOP
{
    public class Student
    {
        private string _fio;
        private DateTime _datestart;
        private string _numzach;
        private int _semester;
        private int[] _grades;

        public string FIO
        {
            get => _fio;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Братишка, ФИО не может быть пустым.");
                
                _fio = value.Trim(); 
            }
        }

        public DateTime DateStart
        {
            get => _datestart;
            init => _datestart = value;
        }

        public string NumZach
        {
            get => _numzach;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Братишка, номер зачетной книжки не может быть пустым.");
                
                _numzach = value.Trim(); 
            }
        }

        public int Semester
        {
            get => _semester;
            init
            {
                if (value < 1)
                    throw new ArgumentException("Братишка, семестр должен быть больше 0.");
                _semester = value;
            }
        }

        public int[] Grades
        {
            get => _grades;
            init
            {
                if (value == null || value.Length != 5)
                    throw new ArgumentException("Должно быть ровно 5 оценок.");
                
                foreach (int grade in value)
                {
                    if (grade < 50 || grade > 100)
                        throw new ArgumentException("Оценка должна быть от 50 до 100.");
                }
                
                _grades = value;
            }
        }

        public Student(string fio, DateTime datestart, string numzach, 
                      int semester, int[] grades)
        {
            FIO = fio;
            DateStart = datestart; 
            NumZach = numzach;     
            Semester = semester;
            Grades = grades;
        }

        public double CalculateAverageGrade()
        {
            if (_grades == null || _grades.Length == 0)
                return 0;

            int sum = 0;
            foreach (int grade in _grades)
            {
                sum += grade;
            }
            
            return (double)sum / _grades.Length;
        }

        public void Display()
        {
            WriteLine("Данные студента: ");
            WriteLine($"ФИО: {FIO}");
            WriteLine($"Дата поступления: {DateStart:dd.MM.yyyy}");
            WriteLine($"Номер зачетной книжки: {NumZach}");
            WriteLine($"Семестр: {Semester}");
            WriteLine("Оценки по предметам:");
            
            for (int i = 0; i < _grades.Length; i++)
            {
                WriteLine($"Предмет {i + 1}: {_grades[i]}");
            }
            
            WriteLine($"Средний балл за семестр: {CalculateAverageGrade():F2}");
            WriteLine();
        }
    }

    class t1
    {
        static void Main()
        {
            Student student1 = new Student(
                fio: "Шевцова Анна Владимировна",
                datestart: new DateTime(2025, 9, 1),
                numzach: "12345",
                semester: 2,
                grades: new int[] { 100, 100, 100, 99, 98 }
            );

            Student student2 = new Student(
                fio: "Жуков Леонид Николаевич",
                datestart: new DateTime(2025, 9, 1),
                numzach: "67890",
                semester: 2,
                grades: new int[] { 100, 83, 99, 75, 87 }
            );

            student1.Display();
            student2.Display();
        }
    }
}