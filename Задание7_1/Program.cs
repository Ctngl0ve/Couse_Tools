namespace Задание7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area1 = Square(3.0, 4.0, 5.0);
            double area2 = Square(4.0, 5.0, 6.0);
            if (area1 > area2)
            {
                Console.WriteLine($"Площадь треугольника 1 больше: {area1} > {area2}");
            }
            else
            {
                if (area1 == area2)
                {
                    Console.WriteLine($"Площадь треугольника 1 и 2 равны {area1} = {area2}");
                }
                else
                {
                    Console.WriteLine($"Площадь треугольника 2 больше {area1} < {area2}");
                }

            }

            static double Square(double x1, double x2, double x3)
            {
                double p = (x1 + x2 + x3) / 2;
                double dokoren = p * (p - x1) * (p - x2) * (p - x3);
                double area = Math.Sqrt(dokoren);
                return area;
            }
        }

    }
}
