using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс усилителя
    public class Amplifier
    {
        // Включение усилителя
        public void On()
        {
            Console.WriteLine("Усилитель включён.");
        }

        // Выключение усилителя
        public void Off()
        {
            Console.WriteLine("Усилитель выключен.");
        }

        // Установка громкости
        public void SetVolume(int level)
        {
            Console.WriteLine($"Усилитель: громкость установлена на {level}.");
        }
    }
}