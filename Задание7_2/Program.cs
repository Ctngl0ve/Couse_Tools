namespace Задание7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину грани куба: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            double z;
            CalcCube(x, out y, out z);
            Console.WriteLine($"Объем: {y}\nПлощадь: {z}");
            Console.ReadKey();

        }
        static void CalcCube(double length, out double v, out double area)
        {
            area = length * length;
            v = area * length;
        }
    }
}
