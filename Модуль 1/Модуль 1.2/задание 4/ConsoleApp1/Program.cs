using System;

namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод размера массива и диапазона значений
            Console.Write("Введите размер массива K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[K];
            Random rnd = new Random();

            // Заполнение массива случайными значениями
            for (int i = 0; i < K; i++)
            {
                array[i] = rnd.Next(A, B);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Поиск индексов минимального и максимального элементов
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < K; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            // Вывод элементов между минимальным и максимальным
            Console.WriteLine("Элементы между минимальным и максимальным:");
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
