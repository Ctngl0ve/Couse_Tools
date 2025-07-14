namespace Задание5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных
            int M = 10;
            int g = 0;
            int s = 0;
            int[] array = new int[M];
            Random ch = new Random();
            for (int i = 0; i < M; i++)
            {
                array[i] = ch.Next(0, 101);
                Console.Write($" {array[i]} ");

            }
            foreach (int a in array)
            {
                if (a % 2 == 0)
                {
                    g = g + 1;

                }
                else 
                {
                    s = s + 1;
                }
            }
            Console.WriteLine();
            Console.Write($"Четные: {g}  нечетные: {s}");
            Console.WriteLine();
            if (g > s)
            {
                Console.Write("Четных больше");
            }
            else
            {
                if (g == s)
                {
                    Console.Write("Поровно");
                }
                else
                {
                    Console.Write("Нечетных больше");
                }
            }
            Console.ReadKey();


        }
    }
}
