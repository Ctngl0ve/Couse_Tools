using System.Collections.ObjectModel;
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

namespace Блок2_Занятие8_Задание2_8_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainWindow()
        {
            InitializeComponent();
            products.Add(new Product()
            {
                Name = "Яблоко",
                Sourses = "D:\\Progect_VS\\Couse_Tools\\Блок2_Занятие8_Задание2_8_1\\Изображения\\Яблоко.jpg",
                Prise = 50,
                Category = CategoryList.Еда

            });
            products.Add(new Product()
            {
                Name = "Пальто",
                Sourses = "D:\\Progect_VS\\Couse_Tools\\Блок2_Занятие8_Задание2_8_1\\Изображения\\Пальто.jpg",
                Prise = 1999,

                Category = CategoryList.БытоваяТехника
            });
            listBox_1.ItemsSource = products;

        }
    }
}