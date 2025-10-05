namespace Задание3_5
{
    internal class Program
    {
        static void Main(string[] args)
        { //Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 10 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
