namespace Задание2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до целых в большую сторону
            double n1 = Convert.ToDouble(Console.ReadLine());
            int n2 = (int)Math.Ceiling(n1);
            Console.WriteLine(n2);
            Console.ReadLine();
        }
    }
}
