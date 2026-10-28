using System;
using static System.Console;

namespace OOP
{
    public abstract class Client
    {
        public string inn { get; private set; }
        public string address { get; private set; }

        public Client(string inn, string address)
        {
            if (string.IsNullOrWhiteSpace(inn))
                throw new ArgumentException("Ошибочка, ИНН не может быть пустым");
            foreach (char ch in inn)
            {
                if (!char.IsDigit(ch))
                    throw new ArgumentException("Ошибочка, ИНН должен состоять только из цифр");
            }
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Ошибочка, адрес не может быть пустым");

            this.inn = inn;
            this.address = address;
        }

        public virtual void Print()
        {
            WriteLine($" ИНН: {inn}");
            WriteLine($" Адрес: {address}");
        }
    }

    public class Person : Client
    {
        public string fio { get; private set; }
        public string pol { get; private set; }
        public int birth_year { get; private set; }

        public Person(string inn, string address, string fio, string pol, int birth_year)
            : base(inn, address)
        {
            if (string.IsNullOrWhiteSpace(fio))
                throw new ArgumentException("Ошибочка, ФИО не может быть пустым");
            if (pol != "м" && pol != "ж" && pol != "Мужской" && pol != "Женский")
                throw new ArgumentException("Обшибочка, пол должен быть \"м\" или \"ж\"");
            if (birth_year < 1900 || birth_year > DateTime.Now.Year)
                throw new ArgumentException("Бро, некорректный год рождения");

            this.fio = fio;
            this.pol = pol;
            this.birth_year = birth_year;
        }

        public override void Print()
        {
            WriteLine("Физическое лицо:");
            WriteLine($"ФИО: {fio}");
            WriteLine($"Пол: {pol}");
            WriteLine($"Год рождения: {birth_year}");
            base.Print();  
            WriteLine();
        }
    }

    // Юридическое лицо
    public class Legal_entity : Client 
    {
        public string name { get; private set; }
        public string opf { get; private set; }         
        public DateTime create_date { get; private set; }

        public Legal_entity(string inn, string address, string name, string opf, DateTime create_date)
            : base(inn, address)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ошибочка, наименование не может быть пустым");
            if (string.IsNullOrWhiteSpace(opf))
                throw new ArgumentException("Ошибочка, организационно-правовая форма не может быть пустой");
            if (create_date > DateTime.Now)
                throw new ArgumentException("Окак, дата создания не может быть в будущем");

            this.name = name;
            this.opf = opf;
            this.create_date = create_date;
        }

        public override void Print()
        {
            WriteLine("Юридическое лицо:");
            WriteLine($"Наименование: {opf} «{name}»");
            WriteLine($"Организационно-правовая форма: {opf}");
            WriteLine($"Дата создания: {create_date:dd.MM.yyyy}");
            base.Print();
            WriteLine();
        }
    }

    class de_4
    {
        static void Main()
        {
            // тестирование физ лица
            Person p = new Person("616512345678", "г. Ростов-на-Дону, ул. Искусственная, 10",
                                  "Шевцова Анна Владимировна", "ж", 2007);
            p.Print();

            // тестирование юр лица
            Legal_entity Urik = new Legal_entity("6164012345", "г. Ростов-на-Дону, пр. Ворошиловский, 5",
                                    "ТТБУБУ", "ООО", new DateTime(2008, 3, 12));
            Urik.Print();


            // проверка разных классов в массиве
            Client[] clients =
            {
                new Person("616598765432", "г. Вологда, ул. Ленина, 3", "Жуков Леонид Николаевич", "м", 2005),
                new Legal_entity("6150098765", "г. Азов, ул. Лермонтовская, 7", "Быстрые отчеты", "АО", new DateTime(2020, 9, 1))
            };

            WriteLine("Клиенты (массив)\n");
            foreach (Client cl in clients)
            {
                cl.Print();   
            }

            // пример обработки некорректных данных
            WriteLine("Братишка, некорректные данные");
            try
            {
                Person bad = new Person("61abc", "г. Ростов", "Иванов Иван", "м", 2000);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка ИНН: {ex.Message}");
            }
            try
            {
                Person bad = new Person("616500000000", "г. Ростов", "Иванов Иван", "м", 2099);
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка физ. лица: {ex.Message}");
            }
            try
            {
                Legal_entity bad = new Legal_entity("6164000000", "г. Ростов", "", "ООО", new DateTime(2010, 1, 1));
            }
            catch (ArgumentException ex)
            {
                WriteLine($"Ошибка юр. лица: {ex.Message}");
            }
        }
    }
}