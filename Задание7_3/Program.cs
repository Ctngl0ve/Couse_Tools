namespace Задание7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers(numbers: ints);
            PrintNumbers(true, ints);
        }

        static void PrintNumbers(bool reverse = false, params int[] numbers)
        {
            if (reverse == false)
            {
                foreach (int number in numbers)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                Array.Reverse(numbers);
                foreach (int number in numbers)
                {
                    Console.Write($" {number}");
                }
            }

        }
    }
}
