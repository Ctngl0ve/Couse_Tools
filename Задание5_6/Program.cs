namespace Задание5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[,] { { 1, 0, 1, 0, 1 }, { 0, 1, 0, 1, 0 }, { 1, 0, 1, 0, 1 }, { 0, 1, 0, 1, 0 }, { 1, 0, 1, 0, 1 }, };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($" {massiv[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
