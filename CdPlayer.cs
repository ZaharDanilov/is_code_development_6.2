using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс CD-плеера
    public class CdPlayer
    {
        // Включение плеера
        public void On()
        {
            Console.WriteLine("CD-плеер включён.");
        }

        // Выключение плеера
        public void Off()
        {
            Console.WriteLine("CD-плеер выключен.");
        }

        // Воспроизведение диска
        public void Play()
        {
            Console.WriteLine("CD-плеер: воспроизведение начато.");
        }

        // Остановка воспроизведения
        public void Stop()
        {
            Console.WriteLine("CD-плеер: воспроизведение остановлено.");
        }
    }
}