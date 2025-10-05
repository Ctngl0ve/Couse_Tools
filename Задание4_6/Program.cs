using Microsoft.VisualBasic;

namespace Задание4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2 - ки ?
            Console.WriteLine("Введите цифру:");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            int st = 0;
            if ((n % k == 0) && ((n / k) % k == 0))
            {
                while (n % k == 0) // почему тут не может подойти? while (n / k == 1)
                {
                    n /= k;
                    st++;
                }
                Console.WriteLine($"Результат {st}");
            }
            else
            {
                Console.WriteLine("Степенью двойки быть не может");
            }

            Console.ReadKey();

        }
    }
}
