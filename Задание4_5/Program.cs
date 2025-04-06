namespace Задание4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в диапозоне от 20 до 60: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 19 && a < 61)
            {
                Console.Write($"Веденное число верное. Число {a} является выигрышным, вы получаете автомобиль. Прошу напишите данные банковской карты на лицевой и обратной стороне ");
            }
            else
            {
                int result = a;
                Console.Write($"Веденное число неверное. Удаление папки Sustems32 начнется через:");
                for (int i = 0; i < a; i = i + 1)
                {
                    result -= 1;
                    Console.WriteLine($"Осталось:{result}c");
                }
            }
            Console.ReadKey();
        }//а это я написал сам

        //    *А вообще можно было использовать цикл while. Код выглядит следующим образом:
        //    начало:
        //        Console.Write("Введите число в диапозоне от 20 до 60: ");
        //        int a = Convert.ToInt32(Console.ReadLine());
        //        while (!(a > 19 && a< 61))
        //        {
        //            goto начало;
        //        }
        //Console.Write("Спасибо");





    }
}
