namespace Задание3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            Console.WriteLine("Введите двухзачное число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = n1 / 10;
            if ((n2 < 10) && (n2 > -10) && (n2 != 0))
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
