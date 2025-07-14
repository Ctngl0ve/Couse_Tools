namespace Задание3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».
            Console.WriteLine("Введите число построенных домов:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (((a1 % 10 > 4) && (a1 % 10 <= 9)) || (a1 % 10 == 0) || ((a1 % 100 > 10) && (a1 % 100 <= 19)))
            {
                Console.WriteLine($"Построено {a1} домов");
            }
            else
            {
                if ((a1 % 10 > 1) && (a1 % 10 < 5))
                {
                    Console.WriteLine($"Построено {a1} дома");
                }
                else
                {
                    Console.WriteLine($"Построено {a1} дом");
                }  
            }
            Console.ReadKey();
        }
    }
}
