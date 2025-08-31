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

namespace Задание2_1_3
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

        Random ran = new Random();

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            int random2 = ran.Next(0, (int)(MyGrid.ActualHeight - button.Height));
            int random1 = ran.Next(0, (int)(MyGrid.ActualWidth - button.Width));

            //double randomOpacity = ran.Next(0, 1);

            button.Margin = new Thickness(random1, random2, 0, 0);
            button.Width = ran.Next(10, 200);
            button.Height = ran.Next(10, 100);
            button.Opacity = ran.NextDouble(); 
        }
    }
}