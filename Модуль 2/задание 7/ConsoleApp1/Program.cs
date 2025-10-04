using System;
struct Train
{
    public string Destination;      // Пункт назначения
    public int TrainNumber;         // Номер поезда
    public TimeSpan DepartureTime;  // Время отправления

    // Конструктор структуры
    public Train(string destination, int trainNumber, TimeSpan departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
    // Метод для вывода информации о поезде
    public void DisplayInfo()
    {
        Console.WriteLine($"Пункт назначения: {Destination}, Номер поезда: {TrainNumber}, Время отправления: {DepartureTime}");
    }
}
class Program
{
    static void Main()
    {
        // Создаем массив поездов
        Train[] trains = new Train[5];

        // Ввод данных о поездах
        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine($"Введите данные для поезда {i + 1}:");
            // Ввод пункта назначения
            Console.Write("Пункт назначения: ");
            string destination = Console.ReadLine();
            // Ввод номера поезда
            Console.Write("Номер поезда: ");
            int trainNumber = int.Parse(Console.ReadLine());

            // Ввод времени отправления
            Console.Write("Время отправления (чч:мм): ");
            TimeSpan departureTime = TimeSpan.Parse(Console.ReadLine());

            // Заполняем массив поездами
            trains[i] = new Train(destination, trainNumber, departureTime);
        }
        // Сортировка поездов по номерам
        SortTrainsByNumber(trains);
        // Запрос у пользователя номера поезда для вывода информации
        FindTrainByNumber(trains);
        // Сортировка поездов по пункту назначения и времени отправления
        SortTrainsByDestinationAndTime(trains);
        // Вывод всех отсортированных поездов
        Console.WriteLine("\nПоезда, отсортированные по пункту назначения и времени отправления:");
        foreach (Train train in trains)
        {
            train.DisplayInfo();
        }
    }
    // Метод для сортировки поездов по номерам
    static void SortTrainsByNumber(Train[] trains)
    {
        // Стандартная сортировка массива поездов с помощью метода CompareTrainsByNumber
        Array.Sort(trains, CompareTrainsByNumber);
    }
    // Метод сравнения поездов по номеру
    static int CompareTrainsByNumber(Train firstTrain, Train secondTrain)
    {
        // Сравниваем номера поездов
        if (firstTrain.TrainNumber > secondTrain.TrainNumber)
            return 1; // Если номер первого поезда больше, то возвращаем 1
        else if (firstTrain.TrainNumber < secondTrain.TrainNumber)
            return -1; // Если номер первого поезда меньше, возвращаем -1
        else
            return 0; // Если номера равны, возвращаем 0
    }
    // Метод для поиска поезда по номеру, введенному пользователем
    static void FindTrainByNumber(Train[] trains)
    {
        Console.Write("Введите номер поезда для вывода информации: ");
        int inputNumber = int.Parse(Console.ReadLine());
        // Ищем поезд по номеру
        Train? foundTrain = null;
        // Проходим по каждому поезду в массиве
        foreach (Train train in trains)
        {
            if (train.TrainNumber == inputNumber)
            {
                foundTrain = train;  // Если поезд найден, сохраняем его
                break;
            }
        }
        // Если поезд найден, выводим информацию
        if (foundTrain != null)
        {
            foundTrain.Value.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Поезд с таким номером не найден.");
        }
    }
    // Метод для сортировки поездов по пункту назначения и времени отправления
    static void SortTrainsByDestinationAndTime(Train[] trains)
    {
        // Сортируем массив поездов с помощью метода CompareTrainsByDestinationAndTime
        Array.Sort(trains, CompareTrainsByDestinationAndTime);
    }
    // Метод сравнения поездов по пункту назначения и времени отправления
    static int CompareTrainsByDestinationAndTime(Train firstTrain, Train secondTrain)
    {
        // Сначала сравниваем пункты назначения
        int destinationComparison = firstTrain.Destination.CompareTo(secondTrain.Destination);
        // Если пункты назначения одинаковые, сравниваем по времени отправления
        if (destinationComparison == 0)
        {
            if (firstTrain.DepartureTime > secondTrain.DepartureTime)
                return 1;  // Если время отправления первого больше
            else if (firstTrain.DepartureTime < secondTrain.DepartureTime)
                return -1;  // Если время отправления первого меньше
            else
                return 0;  // Время отправления одинаковое
        }
        return destinationComparison;  // Возвращаем результат сравнения по пунктам назначения
    }
}
