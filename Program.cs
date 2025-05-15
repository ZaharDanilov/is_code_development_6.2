using is_code_development_6._2;
using System;
using System.Windows.Forms;


namespace HomeTheaterApp
{
   
    static class Program
    {
        // Атрибут, указывающий на использование однопоточной модели STA
        [STAThread]
        static void Main()
        {
            // для современного вида элементов управления
            Application.EnableVisualStyles();
            // Установка совместимости рендеринга текста
            Application.SetCompatibleTextRenderingDefault(false);
            // Запуск приложения с созданием главной формы
            Application.Run(new Form1());
        }
    }
}