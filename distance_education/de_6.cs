using System;
using static System.Console;

namespace OOP
{
    public abstract class Car
    {
        public string brand { get; private set; }       
        public string reg_number { get; private set; }  

        public Car(string brand, string reg_number)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Ошибочка, марка не может быть пустой");
            if (string.IsNullOrWhiteSpace(reg_number))
                throw new ArgumentException("Ошибочка, регистрационный знак не может быть пустым");

            this.brand = brand;
            this.reg_number = reg_number;
        }

        public virtual void Print()
        {
            WriteLine($"Марка: {brand}");
            WriteLine($"Регистрационный знак: {reg_number}");
        }
    }

    public class PassengerCar : Car
    {
        public string type { get; private set; }    
        public int max_speed { get; private set; }   

        public PassengerCar(string brand, string reg_number, string type, int max_speed)
            : base(brand, reg_number)
        {
            if (type is not ("седан" or "хэтчбек" or "универсал"))
                throw new ArgumentException("Ошибочка, тип должен быть: седан, хэтчбек или универсал");
            if (max_speed <= 0 || max_speed > 500)
                throw new ArgumentException("Бро, некорректная максимальная скорость");

            this.type = type;
            this.max_speed = max_speed;
        }

        public override void Print()
        {
            WriteLine("Легковой автомобиль:");
            base.Print();   
            WriteLine($"Тип: {type}");
            WriteLine($"Максимальная скорость: {max_speed} км/ч");
            WriteLine();
        }
    }

    public class Truck : Car
    {
        public double capacity { get; private set; }   

        public Truck(string brand, string reg_number, double capacity)
            : base(brand, reg_number)
        {
            if (capacity <= 0)
                throw new ArgumentException("Обшибочка, грузоподъёмность должна быть больше нуля");

            this.capacity = capacity;
        }

        public override void Print()
        {
            WriteLine("Грузовой автомобиль:");
            base.Print();
            WriteLine($"Грузоподъёмность: {capacity} т");
            WriteLine();
        }
    }

    class de_6
    {
        static void Main()
        {
            // тестирование легкового автомобиля
            PassengerCar pc = new PassengerCar("Toyota Camry", "А123ВС161", "седан", 210);
            pc.Print();

            // тестирование грузового автомобиля
            Truck t = new Truck("КАМАЗ 65115", "Е456КМ161", 15);
            t.Print();

            // разные автомобили в массиве
            Car[] cars =
            {
                new PassengerCar("Kia Rio", "В789ОР161", "хэтчбек", 190),
                new PassengerCar("Lada Largus", "К321МН761", "универсал", 165),
                new Truck("ГАЗель Next", "Т654УХ161", 1.5)
            };

            WriteLine("Автомобили (массив)\n");
            foreach (Car car in cars)
            {
                car.Print();   
            }

            // Обработка некорректных данных
            WriteLine("Братишка, некорректные данные");
            try
            {
                PassengerCar bad = new PassengerCar("BMW", "М111ММ161", "кабриолет", 250);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка легкового: {ex.Message}");
            }

            try
            {
                PassengerCar bad = new PassengerCar("BMW", "М111ММ161", "седан", -10);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка легкового: {ex.Message}");
            }

            try
            {
                Truck bad = new Truck("MAN", "Р222РР161", 0);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка грузового: {ex.Message}");
            }
            
            try
            {
                Truck bad = new Truck("", "Р222РР161", 10);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка автомобиля: {ex.Message}");
            }
        }
    }
}