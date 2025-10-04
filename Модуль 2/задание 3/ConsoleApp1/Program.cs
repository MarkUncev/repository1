using System;

// Класс для автора
class Author
{
    // Имя автора
    public string Name { get; set; }

    // Год рождения автора
    public int BirthYear { get; set; }

    // Конструктор: задаёт имя и год рождения
    public Author(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}

// Класс для книги
class Book
{
    // Название книги
    public string Title { get; set; }

    // Год выпуска книги
    public int ReleaseYear { get; set; }

    // Автор книги
    public Author Author { get; set; }

    // Конструктор: задаёт название, год выпуска и автора
    public Book(string title, int releaseYear, Author author)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
    }

    // Метод для вывода информации о книге
    public void DisplayInfo()
    {
        Console.WriteLine($"Книга: {Title}, Год выпуска: {ReleaseYear}, Автор: {Author.Name}, Год рождения автора: {Author.BirthYear}");
    }
}

class Program
{
    static void Main()
    {
        // Создаём автора.
        Author author = new Author("Владимир Маяковский", 1893);

        // Создаём книгу
        Book book = new Book("Облако в штанах", 1915, author);

        // Выводим информацию о книге
        book.DisplayInfo();
    }
}