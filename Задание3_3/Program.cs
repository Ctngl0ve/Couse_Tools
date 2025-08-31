namespace Задание3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся четыре числа. Вывести большее их них.
            Console.WriteLine("Выведем наибольшее число. Введите первое число: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            int a4 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2) //также можно было сократить скроки используя if((a1 > a2 && a1 >a3 && a1 >a4) Console.WriteLine (a1) и так перебором под каждый вариант
            {
                if (a1 > a3)
                {
                    if (a1 > a4)
                    {

                        Console.WriteLine($"Наибольшее число:{a1}");
                    }
                    else
                    {
                        Console.WriteLine($"Наибольшее число:{a4}");
                    }
                }
                else
                {
                    if (a3 > a4)
                    {

                        Console.WriteLine($"Наибольшее число:{a3}");
                    }
                    else
                    {
                        Console.WriteLine($"Наибольшее число:{a4}");
                    }
                }
            }
            else
            {
                if (a2 > a3)
                {
                    if (a2 > a4)
                    {

                        Console.WriteLine($"Наибольшее число:{a2}");
                    }
                    else
                    {
                        Console.WriteLine($"Наибольшее число:{a4}");
                    }
                }
                else
                {
                    if (a3 > a4)
                    {

                        Console.WriteLine($"Наибольшее число:{a3}");
                    }
                    else
                    {
                        Console.WriteLine($"Наибольшее число:{a4}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
