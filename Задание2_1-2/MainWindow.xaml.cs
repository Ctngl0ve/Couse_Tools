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

namespace Задание2_1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _i = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Color colorGreen = Color.FromRgb(195, 241, 195);
            Color colorYellow = Color.FromRgb(224, 234, 141);
            Color colorRed = Color.FromRgb(243, 131, 131);
            Color colorGray = Color.FromRgb(191, 191, 191);


            if (_i >= 1 && _i <= 3)
            {
                _i = _i + 1;
            }
            else
            {
                _i = 1;
            }

            switch (_i)
            {
                case 1:
                    Ellipse_1.Fill = new SolidColorBrush(colorGreen);
                    Ellipse_2.Fill = new SolidColorBrush(colorGray);
                    Ellipse_3.Fill = new SolidColorBrush(colorGray);
                    break;
                case 2:
                    Ellipse_1.Fill = new SolidColorBrush(colorGray);
                    Ellipse_2.Fill = new SolidColorBrush(colorYellow);
                    Ellipse_3.Fill = new SolidColorBrush(colorGray);
                    break;
                case 3:
                    Ellipse_1.Fill = new SolidColorBrush(colorGray);
                    Ellipse_2.Fill = new SolidColorBrush(colorGray);
                    Ellipse_3.Fill = new SolidColorBrush(colorRed);
                    break;
            }

        }

    }
}

