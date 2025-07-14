namespace Задание4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a (>0): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите число b (может быть отрицательным): ");
            int b = int.Parse(Console.ReadLine());

            double result = 1;
            int exp = Math.Abs(b); // Берём модуль b для работы с положительной степенью

            for (int i = 0; i < exp; i++)
            {
                result *= a;
            }

            if (b < 0)
            {
                result = 1 / result; // Если b отрицательное, берём обратное значение
            }

            Console.WriteLine($"Результат: {result}");
        }
    }//Если бы не чат gpt, вообще не написал бы. какие же циклы непонятные 
    
}
