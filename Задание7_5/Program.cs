namespace Задание7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Multiply(15, 10);
            double result2 = Multiply(15.1, 10.3);
            Console.WriteLine($"Умножение с типом данных int: {result1}\nУмножение с типом данных double: {result2}");
            Console.ReadKey();
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
