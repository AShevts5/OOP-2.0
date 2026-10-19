using System;
using static System.Console;

namespace OOP_2
{
    public class Book
    {
        private string regNumber;
        private string author;
        private string title;
        private int year;
        private string publisher;
        private int pages;

        public Book(string regNumber, string author, string title, int year, string publisher, int pages)
        {
            this.regNumber = regNumber;
            this.author = author;
            this.title = title;
            this.year = year;
            this.publisher = publisher;
            this.pages = pages;
        }

        public void Display()
        {
            WriteLine($"Регистрационный номер: {regNumber}");
            WriteLine($"Автор: {author}");
            WriteLine($"Название: {title}");
            WriteLine($"Год издания: {year}");
            WriteLine($"Издательство: {publisher}");
            WriteLine($"Количество страниц: {pages}");
            WriteLine();
        }
    }

    class LibraryTask
    {
        static void Main1(string[] args)
        {
            WriteLine("Книги, хранящиеся в библиотеке\n");

            Book[] books =
            {
                new Book("Б-00125", "Л. Н. Толстой", "Война и мир", 2019, "Эксмо", 1300),
                new Book("Б-00348", "Ф. М. Достоевский", "Преступление и наказание", 2021, "АСТ", 608),
                new Book("Б-00512", "А. С. Пушкин", "Евгений Онегин", 2020, "Азбука", 320)
            };

            foreach (Book b in books)
                b.Display();

        }
    }
}