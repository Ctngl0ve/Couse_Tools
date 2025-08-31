namespace Задание3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер участка в метрах, в котором нужно разместить два дома: Введите первое число (Длина)");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число (Ширина)");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш участок размером {n1}x{n2}");
            Console.WriteLine("Введите размер первого дома: Первое число (Длина):");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число (Ширина)");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Первый дом размерами {a1}x{a2}");
            Console.WriteLine("Введите размер второго дома: Первое число (Длина):");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число (Ширина)");
            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Второй дом размерами {a3}x{a4}");
            if ((a1 + a3) < n1)
            {
                if ((a2 + a4) < n2)
                {
                    Console.WriteLine("Оба дома могут быть расположены в указанный участок");
                }
                else
                {
                    Console.WriteLine("Оба дома не могут быть расположены в указанный участок");
                }
            }
            else
            {
                Console.WriteLine("Оба дома не могут быть расположены в указанный участок");
            }    
                Console.ReadKey();
        }
    }
}
