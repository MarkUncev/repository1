using System;
namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cоздание массива на 15 элементов
            int[] array = new int[15];

            // Обьявление класса Random
            Random rnd = new Random();

            // Цикл for для заполнения массива рандомаными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.WriteLine($"{array[i]}");
            }

            // Переменная для хранения суммы положительных чисел
            int PlusNumber = 0;

            // Цикл for для перебора всего массива (с условием if для нахождения и подсчета всех положительных чисел)
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > PlusNumber)
                {
                    PlusNumber += array[i];
                }
            }

            Console.WriteLine($"\nСумма всех положительных чисел: {PlusNumber}"); // Вывод результата
            Console.ReadKey(); // Команада чтобы консоль закрывалась не сразу после вывода результата
        }
    }
}
