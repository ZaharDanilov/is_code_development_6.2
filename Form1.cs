using System;
using System.Windows.Forms;

// Пространство имён приложения
namespace HomeTheaterApp
{
    // Класс главной формы
    public partial class Form1 : Form
    {
        // Элементы управления
        private Button btnWatchMovie; // Кнопка для начала просмотра
        private Button btnEndMovie; // Кнопка для завершения просмотра
        private Button btnCheckStatus; // Кнопка для проверки статуса
        private TextBox txtOutput; // Поле для вывода логов
        private HomeTheaterFacade _homeTheater; // Экземпляр фасада

        // Конструктор формы
        public Form1()
        {
            InitializeComponents();
            // Инициализация подсистем
            var projector = new Projector();
            var amplifier = new Amplifier();
            var cdPlayer = new CdPlayer();
            var screen = new Screen();
            var lights = new Lights();
            // Создание фасада
            _homeTheater = new HomeTheaterFacade(projector, amplifier, cdPlayer, screen, lights);
        }

        // Метод инициализации элементов управления
        private void InitializeComponents()
        {
            // Настройка формы
            this.Text = "Домашний кинотеатр"; // Заголовок окна
            this.Size = new System.Drawing.Size(500, 400); // Размер окна
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фиксированный размер
            this.MaximizeBox = false; // Отключение кнопки разворачивания

            // Кнопка "Начать просмотр"
            btnWatchMovie = new Button
            {
                Text = "Начать просмотр",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(140, 30)
            };
            btnWatchMovie.Click += BtnWatchMovie_Click;

            // Кнопка "Завершить просмотр"
            btnEndMovie = new Button
            {
                Text = "Завершить просмотр",
                Location = new System.Drawing.Point(170, 20),
                Size = new System.Drawing.Size(140, 30)
            };
            btnEndMovie.Click += BtnEndMovie_Click;

            // Кнопка "Проверить статус"
            btnCheckStatus = new Button
            {
                Text = "Проверить статус",
                Location = new System.Drawing.Point(320, 20),
                Size = new System.Drawing.Size(140, 30)
            };
            btnCheckStatus.Click += BtnCheckStatus_Click;

            // Поле для вывода логов
            txtOutput = new TextBox
            {
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(440, 280),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] { btnWatchMovie, btnEndMovie, btnCheckStatus, txtOutput });
        }

        // Обработчик нажатия кнопки "Начать просмотр"
        private void BtnWatchMovie_Click(object sender, EventArgs e)
        {
            try
            {
                // Запуск просмотра и вывод лога
                string log = _homeTheater.WatchMovie();
                txtOutput.AppendText(log + "\r\n");
            }
            catch (InvalidOperationException ex)
            {
                // Обработка ошибки повторного запуска
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обработка прочих ошибок
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик нажатия кнопки "Завершить просмотр"
        private void BtnEndMovie_Click(object sender, EventArgs e)
        {
            try
            {
                // Завершение просмотра и вывод лога
                string log = _homeTheater.EndMovie();
                txtOutput.AppendText(log + "\r\n");
            }
            catch (InvalidOperationException ex)
            {
                // Обработка ошибки завершения неактивного просмотра
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Обработка прочих ошибок
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик нажатия кнопки "Проверить статус"
        private void BtnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Вывод статуса системы
                string status = _homeTheater.GetStatus();
                txtOutput.AppendText(status + "\r\n");
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}