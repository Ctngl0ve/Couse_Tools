namespace Задание3_6
{
    internal class Program
    {
        static void Main(string[] args)
        { // Вводится число.Вывести «Да», если оно четное, и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0)
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
