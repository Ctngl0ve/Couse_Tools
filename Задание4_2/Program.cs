namespace Задание4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            Console.WriteLine("Введите цифру:");
            double n = double.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i = i + 1)
            {
                result = result + 1.0 / i;
            }
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }//Если бы не чат gpt, вообще не написал бы. какие же циклы непонятные 
    }
}
