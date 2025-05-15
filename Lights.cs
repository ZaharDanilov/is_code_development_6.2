using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс освещения
    public class Lights
    {
        // Включение освещения
        public void On()
        {
            Console.WriteLine("Освещение включено.");
        }

        // Выключение освещения
        public void Off()
        {
            Console.WriteLine("Освещение выключено.");
        }

        // Установка яркости
        public void Dim(int level)
        {
            Console.WriteLine($"Освещение: яркость установлена на {level}%.");
        }
    }
}