namespace Задание6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 = " ";
            string result2 = " ";
            string result3 = " ";
            string s1 = new string('-', 40);
            Console.WriteLine("Отчет о продажах какого месяца и года Вы хотели ли бы получить?  ");
            string mounthYears = Console.ReadLine();
            Console.WriteLine("Сколько было продано в месяце изделий?  ");
            string kolichestvo = Console.ReadLine();
            int kol = Convert.ToInt32(kolichestvo);
            Random rnd = new Random();
            int ob = rnd.Next();
            decimal sred = ob / kol;
            result1 = string.Format($"{ob:N2}");
            result2 = string.Format($"{kol:F0}");
            result3 = string.Format($"{sred:F2}");
            Console.WriteLine(s1);
            Console.WriteLine($"Отчет о продажах за {mounthYears}: ");
            Console.WriteLine(s1);
            Console.WriteLine($"Информация о продажах: \nОбщая сумма продаж: {result1} р.\nКоличество проданных товаров: {result2} шт.\nСредняя стоимость одного товара: {result3} р.");
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
