using System;

namespace Mod11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите число, факториал которого хотите узнать: "); // Запрос ввода числа

            int factorial = Convert.ToInt32(Console.ReadLine()); // Ввод числа пользователем

            int result = 1; // переменная для хранения результата
            // Цикл  for для нахождения факторила
            for (int i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Фактораил {factorial}! = {result}"); // Вывод результата

            Console.ReadKey(); // Команада чтобы консоль закрывалась не сразу после вывода результата
        }
    }
}
