using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace zd_6
{
    // Струкртура Студент и ее данные (имя; фамилия; возраст; средний балл)
    struct Student
    {
        public string Name;
        public string SurName;
        public int age;
        public double AverageScore;

        // Модификатор для передачи переменных 
        public Student(string Name, string SurName, int age, double AverageScore)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.age = age;
            this.AverageScore = AverageScore;
        }

        // Метод для вывода
        public void WriteUserInfo()
        {
            Console.WriteLine($"Имя студента: {Name}");
            Console.WriteLine($"Фамилия студента: {SurName}");
            Console.WriteLine($"Возраст студента: {age}");
            Console.WriteLine($"Средний балл студента: {AverageScore}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Console.Write("Введите имя студента: ");
            student.Name = Console.ReadLine();
            Console.Write("Введите Фамилию студента:");
            student.SurName = Console.ReadLine();
            Console.Write("Введите возраст студента:");
            student.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите средний балл студента:");
            student.AverageScore = Convert.ToDouble(Console.ReadLine());
            student.WriteUserInfo(); // Вызов метода
            Console.ReadKey();
        }
    }
}
