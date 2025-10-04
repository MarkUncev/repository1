using System;

// Базовый класс для фигур
class Shape
{
    // Площадь по умолчанию
    public virtual double Area() { return 0; }

    // Периметр по умолчанию
    public virtual double Perimeter() { return 0; }
}

// Класс для круга
class Circle : Shape
{
    private double radius;  // Радиус

    // Конструктор: задаёт радиус
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Площадь круга: π * r²
    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    // Периметр круга: 2 * π * r
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Класс для прямоугольника
class Rectangle : Shape
{
    private double width;   // Ширина
    private double height;  // Высота

    // Конструктор: задаёт ширину и высоту
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Площадь: ширина * высота
    public override double Area()
    {
        return width * height;
    }

    // Периметр: 2 * (ширина + высота)
    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Program
{
    static void Main()
    {
        // Создаём круг с радиусом 5
        Shape circle = new Circle(5);

        // Создаём прямоугольник 4x6
        Shape rectangle = new Rectangle(4, 6);

        // Выводим площадь и периметр круга
        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}");

        // Выводим площадь и периметр прямоугольника
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");
    }
}