using Microsoft.Win32;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задание2_2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int _version = 1;
        private string _name = "Б.Ю.Александров";

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            StatusBar.Text = "Открытие файла";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл / *.txt| *.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                Textbox1.Text = File.ReadAllText(openFileDialog.FileName);
                StatusBar.Text = $"Файл, расположенный по пути {StatusBar.Text = openFileDialog.FileName} открыт";
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StatusBar.Text = "Сохранение файла";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл / *.txt| *.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, Textbox1.Text);
                StatusBar.Text = $"Файл сохранен по пути {StatusBar.Text = saveFileDialog.FileName}";

            }
            else
            {
                StatusBar.Text = "Файл не сохранен - Сохранись давай!";
            }

        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            StatusBar.Text = "О программе";
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            WindowAboutProgram windowAboutProgram = new WindowAboutProgram();
            windowAboutProgram.textboxName.Text = _name;
            windowAboutProgram.textboxVersion.Text = $"{_version}";
            windowAboutProgram.textboxDate.Text = $"{today}";
            windowAboutProgram.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StatusBar.Text = "Попытка выхода";
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}