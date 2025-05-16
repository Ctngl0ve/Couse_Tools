namespace Задание3_2
{
    internal class Program
    {
        static void Main(string[] args)
        { //Вводятся три числа. Вывести большее их них.

            Console.WriteLine("Выведем наибольшее число. Введите первое число: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2)
            {
                if (a1 > a3)
                {
                    Console.WriteLine($"Наибольшее число:{a1}");
                }
                else
                {
                    Console.WriteLine($"Наибольшее число:{a3}");
                }
            }
            else
            {
                if (a2 > a3)
                {
                    Console.WriteLine($"Наибольшее число:{a2}");
                }
                else
                {
                    Console.WriteLine($"Наибольшее число:{a3}");
                }
            }
            Console.ReadLine();
        }
    }
}
