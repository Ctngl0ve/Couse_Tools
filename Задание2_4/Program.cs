namespace Задание2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.
            Console.WriteLine("Введите четырехзначное число:");
            int number_0 = Convert.ToInt32(Console.ReadLine());
            int n1 = number_0 / 1000;
            int n2 =(number_0 % 1000) / 100;
            int n3 = ((number_0 % 1000) % 100) / 10;
            int n4 = ((number_0 % 1000) % 100) % 10;
            Console.WriteLine($"{n1}; {n2}; {n3}; {n4}");
            (n2, n4) = (n4, n2);
            Console.WriteLine($"меняем местами 2 и 4 цифру в {number_0} = {n1}; {n2}; {n3}; {n4};");
            Console.ReadLine();
        }
    }
}
