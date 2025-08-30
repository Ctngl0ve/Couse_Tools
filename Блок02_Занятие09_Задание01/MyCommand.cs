using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Блок02_Занятие09_Задание01
{
    internal class MyCommand
    {
        public static RoutedUICommand routedUICommand { get; set; }

        static MyCommand()
        {
            InputGestureCollection inputGestureCollection = new InputGestureCollection();
            inputGestureCollection.Add(new KeyGesture(Key.C, ModifierKeys.Control, "Cntr+C"));
            inputGestureCollection.Add(new KeyGesture(Key.Right, ModifierKeys.None, "Право"));
            routedUICommand = new RoutedUICommand("Изменить цвет", "пропуск2", typeof(MyCommand), inputGestureCollection);
        }


    }
}
