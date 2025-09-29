using System;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: "); // Запрос у пользователя ввести первое число

            int a = Convert.ToInt32(Console.ReadLine()); // Ввод первого числа пользователем

            Console.Write("Введите второе целое число: "); // Запрос у пользователя ввести первое число

            int b = Convert.ToInt32(Console.ReadLine()); // Ввод второго числа пользователем

            int result = a + b; // Вычисление суммы двух чисел

            Console.WriteLine($"Полученный результат суммы двух чисел: {result}"); // Вывод результата

            Console.ReadKey(); // Команада чтобы консоль закрывалась не сразу после вывода результата
        }
    }
}
