using System;
using System.ComponentModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace Блок02_Занятие09_Задание01
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
        Random random = new Random();
        private Stack<Brush> _colorHistory = new Stack<Brush>();
        private Brush _color;
        public Brush CurrentColor
        {
            get => _color;
            set
            {
                _color = value;
                if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
                {
                    _colorHistory.Push(value);
                }

                ColorChangeGrid.Background = _color;
            }

        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CurrentColor = new SolidColorBrush(Color.FromRgb(
            (byte)random.Next(256),
            (byte)random.Next(256),
            (byte)random.Next(256)));

            ColorChangeGrid.Background = CurrentColor;
        }
        private void Undo(object sender, ExecutedRoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop();
                CurrentColor = _colorHistory.Pop();
            }

        }
    }

}