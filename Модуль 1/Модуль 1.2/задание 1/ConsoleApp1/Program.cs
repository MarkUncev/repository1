using System;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод размера массива
            Console.Write("Введите размер массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[N];

            // Ввод элементов массива
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Поиск максимального по модулю элемента
            double maxAbs = Math.Abs(array[0]);
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > maxAbs)
                {
                    maxAbs = Math.Abs(array[i]);
                }
            }

            // Нормировка элементов массива
            for (int i = 0; i < N; i++)
            {
                array[i] /= maxAbs;
            }

            // Вывод измененного массива
            Console.WriteLine("Нормированные элементы массива:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
