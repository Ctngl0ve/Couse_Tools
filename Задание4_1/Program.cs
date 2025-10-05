namespace Задание4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
            Console.WriteLine("Введите цифру:");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
