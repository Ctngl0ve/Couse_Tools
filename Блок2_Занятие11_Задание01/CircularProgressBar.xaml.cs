using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Блок2_Занятие11_Задание01
{
    /// <summary>
    /// Логика взаимодействия для CircularProgressBar.xaml
    /// </summary>
    public partial class CircularProgressBar : UserControl
    {
        public CircularProgressBar()
        {
            InitializeComponent();
            UpdateProgress();
        }


        public static readonly DependencyProperty RotateTransformAglePropetrty =
            DependencyProperty.Register(
            nameof(RotateTransformAgle),
            typeof(double),
            typeof(CircularProgressBar),
              new PropertyMetadata(0.0, OnValueChanged));

        public double RotateTransformAgle
        {
            get => (double)GetValue(RotateTransformAglePropetrty);
            set => SetValue(RotateTransformAglePropetrty, value);
        }

        public static readonly DependencyProperty TextOutValueProperty =
            DependencyProperty.Register(
            nameof(TextOutValue),
            typeof(string),
            typeof(CircularProgressBar),
            new PropertyMetadata("0 %"));

        public string TextOutValue
        {
            get => (string)GetValue(TextOutValueProperty);
            set => SetValue(TextOutValueProperty, value);
        }

        private void UpdateProgress()
        {
            double TextOutValueQ = RotateTransformAgle / 3.6;
            TextOutValue = $"{(int)TextOutValueQ} %";

            UpdateArcEndPoint(RotateTransformAgle);
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (CircularProgressBar)d;
            progressBar.UpdateProgress();
        }

        public static readonly DependencyProperty endPointPresentProperty = DependencyProperty.Register(
            nameof(endPointPresent1), typeof(Point), typeof(CircularProgressBar), new PropertyMetadata(new Point(50, 0)));

        public Point endPointPresent1
        {
            get => (Point)GetValue(endPointPresentProperty);
            set => SetValue(endPointPresentProperty, value);
        }



        private void UpdateArcEndPoint(double angle)
        {
            double radians = (angle - 90) * (Math.PI / 180);

            double x = 50 + 50 * Math.Cos(radians);
            double y = 50 + 50 * Math.Sin(radians);

            endPointPresent1 = new Point(x, y);
        }
    }
}
