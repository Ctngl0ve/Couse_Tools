using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Задание2_3_1
{
    /// <summary>
    /// Логика взаимодействия для WindowWinner.xaml
    /// </summary>
    public partial class WindowWinner : Window
    {
        public WindowWinner()
        {
            InitializeComponent();
        }




        internal void button_2Player_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            textBlock_Comp.Text = Convert.ToString(rand.Next(0, 10000));

            int x_2Player = Convert.ToInt32(textBlock_2Player.Text);
            int x_coomp = Convert.ToInt32(textBlock_Comp.Text);
            if (x_2Player > x_coomp)
            {
                MessageBox.Show("Вообще везунчик", "Окно успеха");
            }
            else
            {
                MessageBox.Show("Увы, не сегодня", "Окно проигрыша");
            }
        }
    }
}
