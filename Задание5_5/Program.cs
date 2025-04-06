namespace Задание5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
         //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. Вывести отсортированный таким образом массив на экран

            int M = 10;
            int[] array = new int[M];
            Random chislo = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = chislo.Next(-50, 51);
                Console.Write($"  {array[i]}  ");

            }
            Array.Sort(array); //Предпологаю, что нужно делаить данный массив на 2 массива и каждый сортировать/
            Array.Reverse(array);
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"  {array[i]}  ");
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
