using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using Блок2_Занятие10_Задание01.ViewModels;
using Color = System.Drawing.Color;


namespace Блок2_Занятие10_Задание01.Models
{
    internal class YesOrNotConverter : IValueConverter
    {

        public SolidColorBrush TrueColor { get; set; } = Brushes.Green;
        public SolidColorBrush FalseColor { get; set; } = Brushes.Red;



        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return TrueColor;
            }
            return FalseColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
