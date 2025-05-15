using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс экрана
    public class Screen
    {
        // Опускание экрана
        public void Down()
        {
            Console.WriteLine("Экран опущен.");
        }

        // Поднятие экрана
        public void Up()
        {
            Console.WriteLine("Экран поднят.");
        }
    }
}