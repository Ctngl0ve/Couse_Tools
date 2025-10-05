using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задание2_3_1
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
        int i = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            i++;
            if (i == 20)
            {
                WindowWinner windowWinner = new WindowWinner();
                windowWinner.Show();
            }


            Regex regex = new Regex("[А-яА-яA-Za-z]$");
            string textName = fIO.Text;
            foreach (char name in textName)
            {
                if (string.IsNullOrWhiteSpace(textName))
                {
                    MessageBox.Show("Ошибка: необходимо заполнить поле ФИО", "Окно об ошибке", MessageBoxButton.OK);
                    return;
                }
                if (!regex.IsMatch(textName))
                {
                    MessageBox.Show("Ошибка: поле ФИО должно состоять из буквенных значений", "Окно об ошибке", MessageBoxButton.OK);
                    return;
                }
            }

            string facylt = Facylty.Text;
            if (string.IsNullOrWhiteSpace(facylt))
            {
                MessageBox.Show("Ошибка: Выберите факультет вашего обучения", "Окно об ошибке");
                return;
            }

            var interesCourse = listCourse.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.Content.ToString())
                .ToList();


            string messendge = ($"ФИО: {textName}\n" +
                $"Пол: {(man.IsChecked == true ? "Мужской" : "Женский")}\n" +
                $"Факультет: {facylt} \n" +
                $"Курс: {string.Join(", ", interesCourse)}\n" +
                $"Желаемое количество часов: {((int)clock.Value)}");


            if (chechBox.IsChecked == false)
            {
                MessageBox.Show("Ошибка: необходимо согласиться на обработку персональных данных", "Окно об ошибке", MessageBoxButton.OK);
                return;
            }

            MessageBox.Show(messendge, "Заявление принято", MessageBoxButton.OK);

        }

        private void clock_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int x = (int)clock.Value;
            if (textBlockSlider != null)
            {
                textBlockSlider.Text = x.ToString();
            }
        }

        private void ban_Checked(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                MessageBox.Show("Бог поможет, перезапускай комп", "Вечная ошибка");
            }
        }
    }
}