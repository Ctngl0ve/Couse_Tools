using System;

namespace Задание2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол для перевода в радианы");
            Console.WriteLine("Введите градусы угла:");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты угла:");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите cекунды угла:");
            int number_3 = Convert.ToInt32(Console.ReadLine());
            int rag_1_3 = number_1 + (number_2 / 60) + ((number_3 / 60) / 60);
            double rad = (double)(rag_1_3 * (Math.PI / 180)); 
            Console.WriteLine($"Ваш угол {number_1},{number_2},{number_3} = {rad} радиан");
            Console.ReadLine();
            /* я не понимаю, почему я пытался начальный инт сконвертить в дабл, но он все 
             * не ставил эту поганую точку 
             * а в строке 17 нате пожалуйста
             */

        }
    }
}
