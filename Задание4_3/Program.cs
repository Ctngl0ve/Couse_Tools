namespace Задание4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            Console.WriteLine("Введите цифру больше 0:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру больше 0:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < b; i = i + 1)
            {
                result *= a;

            }
            Console.WriteLine($"Результат {a} в степени {b} = {result}");
            Console.ReadKey();
            //Если бы не чат gpt, вообще не написал бы. какие же циклы непонятные 
        }
    }
}
