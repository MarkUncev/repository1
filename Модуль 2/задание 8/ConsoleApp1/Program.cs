using System;

// Абстрактный базовый класс для фигур
abstract class Shape
{
    // Абстрактный метод для площади (должен быть реализован в подклассах)
    public abstract double Area();

    // Абстрактный метод для периметра (должен быть реализован в подклассах)
    public abstract double Perimeter();
}

// Класс для круга, наследует от Shape
class Circle : Shape
{
    private double radius;  // Радиус круга

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

// Класс для прямоугольника, наследует от Shape
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

// Класс для треугольника, наследует от Shape
class Triangle : Shape
{
    private double sideA;  // Сторона A
    private double sideB;  // Сторона B
    private double sideC;  // Сторона C

    // Конструктор: задаёт все стороны
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    // Площадь по формуле Герона: sqrt(s * (s-a) * (s-b) * (s-c)), где s - полупериметр
    public override double Area()
    {
        double s = Perimeter() / 2; // Полупериметр
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    // Периметр: сумма всех сторон
    public override double Perimeter()
    {
        return sideA + sideB + sideC;
    }
}

class Program
{
    static void Main()
    {
        // Создаём круг с радиусом 6
        Shape circle = new Circle(6);

        // Создаём прямоугольник 5x7
        Shape rectangle = new Rectangle(5, 7);

        // Создаём треугольник со сторонами 5, 3, 6
        Shape triangle = new Triangle(5, 3, 6);

        // Выводим площадь и периметр круга
        Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}");

        // Выводим площадь и периметр прямоугольника
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}");

        // Выводим площадь и периметр треугольника
        Console.WriteLine($"Площадь треугольника: {triangle.Area()}, Периметр: {triangle.Perimeter()}");
    }
}
