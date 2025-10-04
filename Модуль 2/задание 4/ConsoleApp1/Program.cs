using System;

// Интерфейс для рисования фигур
interface IDrawable
{
    // Метод для рисования фигуры
    void Draw();
}

// Класс для круга, реализует IDrawable
class Circle : IDrawable
{
    // Рисует круг
    public void Draw()
    {
        Console.WriteLine("Рисую круг");
    }
}

// Класс для прямоугольника, реализует IDrawable
class Rectangle : IDrawable
{
    // Рисует прямоугольник
    public void Draw()
    {
        Console.WriteLine("Рисую прямоугольник");
    }
}

// Класс для треугольника, реализует IDrawable
class Triangle : IDrawable
{
    // Рисует треугольник
    public void Draw()
    {
        Console.WriteLine("Рисую треугольник");
    }
}

class Program
{
    static void Main()
    {
        // Массив фигур типа IDrawable
        IDrawable[] shapes = new IDrawable[]
        {
            new Circle(),       // Круг
            new Rectangle(),    // Прямоугольник
            new Triangle()      // Треугольник
        };

        // Перебор массива и рисование каждой фигуры
        foreach (IDrawable shape in shapes)
        {
            shape.Draw();
        }
    }
}