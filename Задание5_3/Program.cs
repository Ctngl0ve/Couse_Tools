using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Задание5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы
            int M = 10;
            int max = 0;
            int min = 0;
            int maxIndex = 0;
            int minIndex = 0;
            int[] array = new int[M];
            Random Chislo = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Chislo.Next(0, 51);
                Console.Write($" {array[i]} ");

                foreach (int a in array)
                {
                    min = array.Min();
                    max = array.Max();
                }
                Console.WriteLine($" Индексы: {i}");
                if (array[i] != min)
                {
                    minIndex = i;
                    
                }
// тут я не понимаю почему он не выводит минимум, думаю, что проблема в том что нет else и if на if накладывается


                if (array[i] == max)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine();
            Console.Write($" Наименьшее число:{min} (Индекс:{minIndex}) \n Наибольшее число: {max} (Индекс:{maxIndex})");
            Console.ReadKey();
        }
    }
}
