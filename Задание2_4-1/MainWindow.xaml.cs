using System.Security.RightsManagement;
using System.Text;
using System.Windows;
using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace Задание2_4_1
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




    }


    public class ClickNameColorButton : Button
    {
        public static readonly DependencyProperty ClickNameColorProperty = DependencyProperty.Register(
            nameof(ClickNameColor),
            typeof(bool),
            typeof(ClickNameColorButton),
            new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.None,
                ClickColorName));

        public bool ClickNameColor
        {
            get { return (bool)GetValue(ClickNameColorProperty); }
            set { SetValue(ClickNameColorProperty, value); }
        }

        private static void ClickColorName(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (ClickNameColorButton)d;
            button.ClickBoolNameColor();
        }

        private void ClickBoolNameColor()
        {
            Content = ClickNameColor ? "OFF" : "ON";
            Background = ClickNameColor ? Brushes.Red : Brushes.Green;
        }

        public ClickNameColorButton()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pa = Path.Combine(desktop, "informatoin.txt");

            File.WriteAllText(pa, "Кнопка нажата: " + DateTime.Now);

            ClickBoolNameColor();

            Click += (cender, e) => ClickNameColor = !ClickNameColor;

            File.AppendAllText(pa, $"Новая запись: {DateTime.Now}\n");
        }
    }
}