using System;

namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите строку, которую хотите вывести в обратном порядке: "); // Запрос у пользователя ввести строку

            string str = Console.ReadLine(); // Ввод пользовтелем строки

            char[] reverse = str.Reverse().ToArray(); // Функкции для реверса строки

            Console.WriteLine(reverse); // Вывод результата

            Console.ReadKey(); // Команада чтобы консоль закрывалась не сразу после вывода результата
        }
    }
}
