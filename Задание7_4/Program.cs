namespace Задание7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int findMax = FindMax(a);
            Console.WriteLine($"Наибольшее число: {findMax}");
            Console.ReadKey(); 
        }

        static int FindMax(params int[] numbers)
        {
            int findMax = 0;
            foreach (int number in numbers)
            {
                if (number > findMax)
                    findMax = number;
            }
            return findMax;
        }
    }
}
