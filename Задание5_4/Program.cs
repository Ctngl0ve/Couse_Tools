namespace Задание5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]. Перевернуть массив, т.е. переставить элементы массива в обратном порядке
            int M = 10;
            int[] array = new int [M];
            Random randomny = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomny.Next(0, 11);
                Console.Write($" {array[i]} ");

            }
            Array.Reverse(array);
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
