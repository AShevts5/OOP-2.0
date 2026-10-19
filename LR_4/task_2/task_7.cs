using System;
using static System.Console;

namespace OOP_2
{
    public class Player
    {
        private string country;
        private string team;
        private string fullName;
        private int number;
        private int age;
        private int height;     
        private double weight; 

        public Player(string country, string team, string fullName, int number, int age, int height, double weight)
        {
            this.country = country;
            this.team = team;
            this.fullName = fullName;
            this.number = number;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public void Display()
        {
            WriteLine($"Страна: {country}");
            WriteLine($"Команда: {team}");
            WriteLine($"ФИО игрока: {fullName}");
            WriteLine($"Игровой номер: {number}");
            WriteLine($"Возраст: {age}");
            WriteLine($"Рост: {height} см");
            WriteLine($"Вес: {weight} кг");
            WriteLine();
        }
    }

    class SportsTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Участники спортивных соревнований\n");

            Player[] players =
            {
                new Player("Россия", "Ростов", "Шевцова Анна Владимировна", 10, 18, 182, 70.5),
                new Player("Россия", "Ростов", "Серова Мила Евгеньевна", 7, 20, 176, 65.0),
                new Player("ОАЭ", "Шо-то там", "Камалин Игорь Владимирович", 23, 22, 190, 85.3)
            };

            foreach (Player p in players)
                p.Display();

        }
    }
}