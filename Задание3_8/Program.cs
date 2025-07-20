namespace Задание3_8
{
    internal class Program
    {
        static void Main(string[] args)
        { //Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
            Console.WriteLine("Введите число:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if ((n1 < 11) && (n1 > -11))
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
