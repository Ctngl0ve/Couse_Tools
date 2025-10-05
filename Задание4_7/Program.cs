namespace Задание4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int N = n;
            int result = 1;
            while (!(n / 10 == 0))
            {
                n = n / 10;
                result++;
            }
            Console.WriteLine($"Веденное число состоит из {result}");
            Console.ReadKey();
        }
    }
}
