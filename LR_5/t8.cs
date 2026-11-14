using System;
using static System.Console;

namespace OOP
{
    public class Applicant
    {
        private string _fio;
        private string _address;
        private double[] _scores;

        public string FIO
        {
            get => _fio;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ФИО абитуриента не может быть пустым.");
                _fio = value.Trim();
            }
        }

        public string Address
        {
            get => _address;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Адрес абитуриента не может быть пустым.");
                _address = value.Trim();
            }
        }

        public double[] Scores
        {
            get => _scores;
            init
            {
                if (value == null || value.Length != 3)
                    throw new ArgumentException("Должно быть ровно 3 балла по предметам.");
                
                foreach (double score in value)
                {
                    if (score < 0 || score > 100)
                        throw new ArgumentException("Балл должен быть в диапазоне от 0 до 100.");
                }
                
                _scores = value;
            }
        }

        public Applicant(string fio, string address, double[] scores)
        {
            FIO = fio;
            Address = address;
            Scores = scores;
        }

        public double CalculateAverage()
        {
            if (_scores == null || _scores.Length < 0)
                return 0;

            double sum = 0;
            foreach (double score in _scores)
            {
                sum += score;
            }
            return sum / _scores.Length;
        }

        public void Display()
        {
            WriteLine("Данные абитуриента:");
            WriteLine($"ФИО: {FIO}");
            WriteLine($"Адрес: {Address}");
            WriteLine("Баллы по предметам:");
            
            for (int i = 0; i < _scores.Length; i++)
            {
                WriteLine($"Предмет {i + 1}: {_scores[i]:F0}");
            }
            
            WriteLine($"Средний балл: {CalculateAverage():F2}");
            WriteLine();
        }
    }

    class t8
    {
        static void Main()
        {

            Applicant applicant1 = new Applicant(
                fio: "Шевцова Анна Владимировна",
                address: "г. Ростов-папа, ул. Ленина, д. 10, кв. 5",
                scores: new double[] { 100, 97, 93 }
            );

            Applicant applicant2 = new Applicant(
                fio: "Кудинов Кирилл Андреевич",
                address: "г. Ростов-папа, ул. Герасименко, д. 25, кв. 12",
                scores: new double[] { 95, 88, 91 }
            );

            applicant1.Display();
            applicant2.Display();

        }
    }
}