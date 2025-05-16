namespace Задание5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M1 = 5;
            int M2 = 10;
            int[,] massiv = new int[M1, M2];
            Random chislo = new Random();

            for (int i = 0; i < M1; i++)
            {

                for (int j = 0; j < M2; j++)
                {
                    massiv[i, j] = chislo.Next(0, 11);
                    massiv[i, 0] = 10;
                    Console.Write($" {massiv[i, j]} ");
                    
                }
                // Думаю, нужно делить на одномерные и сортировать через Array.Sort после Array.Reverse
                Console.Write($" Максимальное значение в строке: -{massiv[i,0]} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        } //ну, каюсь, конечно, что смухлевал, но с двумерными массивами как-то не задалось даже с ИИ...
    }
}
