using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Задание2_5_1
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

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            string deldesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string delName = "Удалить";
            string folderName = System.IO.Path.Combine(deldesktop, delName);
            if (Directory.Exists(folderName)) Directory.Delete(folderName, true);

        }
    }
}