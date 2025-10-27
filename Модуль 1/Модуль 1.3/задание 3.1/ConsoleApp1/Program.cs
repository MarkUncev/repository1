using System;

abstract class Figure  // Абстрактный класс: шаблон для наследования, не инстанцируется.
{
    public abstract double CalculatingSquare();  // Абстрактный метод: реализуется в наследниках.
}

class Circle : Figure  // Наследование: Circle использует метод из Figure.
{
    public double Radius { get; set; }  // Авто-свойство: для доступа к данным.

    public Circle(double radius)
    {
        Radius = radius;  // Инициализация в конструкторе.
    }

    public override double CalculatingSquare()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Figure
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculatingSquare()
    {
        return Length * Width;
    }
}

class Triangle : Figure
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double CalculatingSquare()
    {
        return (BaseLength * Height) / 2;
    }
}

delegate double AreaDelegate(Figure figure);  // Делегат: тип для ссылок на методы (динамический вызов).

class Program
{
    static void Main()  // Точка входа: запускается автоматически.
    {
        Figure circle = new Circle(8);
        Figure rectangle = new Rectangle(2, 7);
        Figure triangle = new Triangle(5, 8);

        AreaDelegate circleDelegate = (fig) => fig.CalculatingSquare();  // Лямбда: анонимная функция для делегата.
        AreaDelegate rectangleDelegate = (fig) => fig.CalculatingSquare();
        AreaDelegate triangleDelegate = (fig) => fig.CalculatingSquare();

        Console.WriteLine($"Площадь круга: {circleDelegate(circle):F2}");
        Console.WriteLine($"Площадь прямоугольника: {rectangleDelegate(rectangle):F2}");
        Console.WriteLine($"Площадь треугольника: {triangleDelegate(triangle):F2}");

        Console.ReadKey();  // Пауза перед закрытием.
    }
}
