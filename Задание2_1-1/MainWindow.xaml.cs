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

namespace Задание2_1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            i += 1;
            TextBlock1.Text = ($"{i}");
        }

        private void TextBlock1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            i = 0;
            TextBlock1.Text = ($"{i}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            TextBlock1.Text = ($"{i}");
        }


        //Как сделать скругление кнопки? 
    }
}