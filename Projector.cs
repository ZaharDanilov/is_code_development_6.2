using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс проектора
    public class Projector
    {
        // Включение проектора
        public void On()
        {
            Console.WriteLine("Проектор включён."); // Имитация действия
        }

        // Выключение проектора
        public void Off()
        {
            Console.WriteLine("Проектор выключен.");
        }

        // Установка источника входного сигнала
        public void SetInput(string input)
        {
            Console.WriteLine($"Проектор: установлен источник {input}.");
        }
    }
}