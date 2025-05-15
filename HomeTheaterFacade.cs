using System;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс Фасад для управления домашним кинотеатром
    public class HomeTheaterFacade
    {
        private Projector _projector; // Экземпляр проектора
        private Amplifier _amplifier; // Экземпляр усилителя
        private CdPlayer _cdPlayer; // Экземпляр CD-плеера
        private Screen _screen; // Экземпляр экрана
        private Lights _lights; // Экземпляр освещения
        private bool _isMoviePlaying; // Флаг состояния просмотра

        // Конструктор, принимающий все подсистемы
        public HomeTheaterFacade(Projector projector, Amplifier amplifier, CdPlayer cdPlayer, Screen screen, Lights lights)
        {
            _projector = projector;
            _amplifier = amplifier;
            _cdPlayer = cdPlayer;
            _screen = screen;
            _lights = lights;
            _isMoviePlaying = false; // Изначально просмотр не активен
        }

        // Метод для начала просмотра фильма
        public string WatchMovie()
        {
            if (_isMoviePlaying)
            {
                throw new InvalidOperationException("Фильм уже воспроизводится!");
            }

            string log = "Подготовка к просмотру фильма...\n";
            _lights.Dim(10); // Приглушение света
            log += "Освещение: яркость установлена на 10%.\n";
            _screen.Down(); // Опускание экрана
            log += "Экран опущен.\n";
            _projector.On(); // Включение проектора
            log += "Проектор включён.\n";
            _projector.SetInput("CD"); // Установка источника
            log += "Проектор: установлен источник CD.\n";
            _amplifier.On(); // Включение усилителя
            log += "Усилитель включён.\n";
            _amplifier.SetVolume(50); // Установка громкости
            log += "Усилитель: громкость установлена на 50.\n";
            _cdPlayer.On(); // Включение CD-плеера
            log += "CD-плеер включён.\n";
            _cdPlayer.Play(); // Начало воспроизведения
            log += "CD-плеер: воспроизведение начато.\n";
            _isMoviePlaying = true; // Обновление статуса
            log += "Просмотр фильма начат!\n";
            return log;
        }

        // Метод для завершения просмотра
        public string EndMovie()
        {
            if (!_isMoviePlaying)
            {
                throw new InvalidOperationException("Просмотр фильма не активен!");
            }

            string log = "Завершение просмотра фильма...\n";
            _cdPlayer.Stop(); // Остановка CD-плеера
            log += "CD-плеер: воспроизведение остановлено.\n";
            _cdPlayer.Off(); // Выключение CD-плеера
            log += "CD-плеер выключен.\n";
            _amplifier.Off(); // Выключение усилителя
            log += "Усилитель выключен.\n";
            _projector.Off(); // Выключение проектора
            log += "Проектор выключен.\n";
            _screen.Up(); // Поднятие экрана
            log += "Экран поднят.\n";
            _lights.On(); // Включение освещения
            log += "Освещение включено.\n";
            _isMoviePlaying = false; // Обновление статуса
            log += "Просмотр фильма завершён!\n";
            return log;
        }

        // Метод для проверки статуса системы
        public string GetStatus()
        {
            return _isMoviePlaying ? "Система: Просмотр фильма активен." : "Система: Просмотр фильма не активен.";
        }
    }
}