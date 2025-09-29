using System;

namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: "); // Запрос пользователя ввести число
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true; // Переменная для проверки числа на остаток

            if (number < 2)
            {
                isPrime = false; // Числа меньше 2 не являются простыми
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break; // Если делится, выходим из цикла
                    }
                }
            }

            // Вывод сообщения простое или нет
            if (isPrime)
            {
                Console.WriteLine($"{number} является простым числом.");
            }
            else
            {
                Console.WriteLine($"{number} не является простым числом.");
            }
        }
    }
}
