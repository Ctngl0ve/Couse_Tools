namespace Задание2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int number_3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Выводим выписанные числа: {number_2}, {number_3},{number_1}");
            Console.WriteLine($"Выводим выписанные числа: {number_3}, {number_1},{number_2}");
        }
    }
}
