namespace Задание3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравним два числа. Введите первое число:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2)
            {
                Console.WriteLine("знак: >");
            }
            if (a1 < a2)
            {
                Console.WriteLine("знак: <");
            }
            if (a1 == a2)
            {
                Console.WriteLine("знак: =");
            }

            Console.ReadLine();
        }
    }
}
