namespace Задание5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов
            int M = 10;
            int plus = 0;
            int minus = 0;
            int nyll = 0;
            int[] array = new int[M];
            Random Chislo = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Chislo.Next(-20, 21);
                Console.Write($" {array[i]} ");
            }
            foreach (int a in array)
            {
                if (!(a == 0))
                {
                    if (a > 0)
                    {
                        plus++;
                    }
                    else
                    {
                        minus++;
                    }
                }
                else
                {
                    nyll++;
                }

            }
            Console.WriteLine();
            Console.WriteLine($" Положительных чисел: {plus} \n Отрицательных чисел: {minus} \n Нулей: {nyll}");
            Console.ReadKey();
        }
    }
}
