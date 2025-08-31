using System.Runtime.Intrinsics.Arm;

namespace Задание17_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //
            Task<int[]> task1 = Task.Run(() => Array(5));

            Task<int> task2 = task1.ContinueWith(ProccesTack =>
            {
                int[] array = ProccesTack.Result;
                return CalculateSum(array);
            });
            Console.WriteLine(task2.Result);
            //

            //ИЛИ

            //
            int[] array = await Task.Run(() => Array(10));
            int sum = await Task.Run(() => CalculateSum(array));
            Console.WriteLine(sum);
            //

            Console.ReadKey();
        }

        static int[] Array(int a)
        {
            Console.WriteLine("Генерация массива...");
            int[] array = new int[a];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write($" {array[i]}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }
        static int CalculateSum(int[] array)
        {
            Console.WriteLine("Вычисление среднего значения ...");
            int sum = 0;

            foreach (int x in array)
            {
                sum = sum + x;
            }
            Thread.Sleep(5000);
            Console.WriteLine("Среднее значение получено ...");
            Thread.Sleep(500);
            return sum / array.Length;
        }

    }
}
