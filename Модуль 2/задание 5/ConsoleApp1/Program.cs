using System;

// Класс для сенсора температуры
class TemperatureSensor
{
    // Событие изменения температуры (тип Action<int>)
    public event Action<int> TemperatureChanged;

    // Приватное поле для текущей температуры
    private int temperature;

    // Свойство Temperature с геттером и сеттером
    public int Temperature
    {
        get { return temperature; }
        set
        {
            // Если температура изменилась, обновляем и вызываем событие
            if (temperature != value)
            {
                temperature = value;
                OnTemperatureChanged(value);
            }
        }
    }

    // Защищённый виртуальный метод для вызова события
    protected virtual void OnTemperatureChanged(int newTemperature)
    {
        TemperatureChanged?.Invoke(newTemperature);
    }
}

// Класс для термостата
class Thermostat
{
    // Метод, который реагирует на изменение температуры
    public void OnTemperatureChanged(int newTemperature)
    {
        // Проверка: если выше 25, включаем кондиционер
        if (newTemperature > 25)
        {
            Console.WriteLine("Температура слишком высокая, включаю кондиционер.");
        }
        // Если ниже 10, включаем отопление
        else if (newTemperature < 11)
        {
            Console.WriteLine("Температура слишком низкая, включаю отопление.");
        }
        // Иначе - норма
        else
        {
            Console.WriteLine("Температура в норме.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаём сенсор температуры
        TemperatureSensor sensor = new TemperatureSensor();

        // Создаём термостат
        Thermostat thermostat = new Thermostat();

        // Подписываем термостат на событие изменения температуры
        sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

        // Изменяем температуру
        sensor.Temperature = 30;  // Температура слишком высокая
        sensor.Temperature = 10;  // Температура слишком низкая
        sensor.Temperature = 22;  // Температура в норме
    }
}