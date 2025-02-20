namespace Задание2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше первое число {a1}, Ваше второе число {a2}");
            (a1 , a2) = (a2 , a1);
            Console.WriteLine($"Обмен местами числа без использования третьей переменной = {a1}, {a2}");
            Console.ReadLine();

        }
    }
}
