using System.Runtime;

namespace Задание3_4
{
    internal class Program
    {
        static void Main(string[] args)
        { //Вводятся три разных числа. Вывести медиану – среднее по величине число.
            Console.WriteLine("Среднее скольких числе вы хотели бы посчитать?.Введите число от 1 до 3:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Выведем среднее из {n1} чисел");
            switch (n1)
            {
                case 1:
                    {
                        Console.WriteLine("Введите первое число:");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Среднее: {a1 / n1}");
                        break;
                    } 
                case 2:
                    {
                        Console.WriteLine("Введите первое число:");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Среднее: {(a1 + a2) / n1}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите первое число:");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Среднее: {(a1 + a2 + a3) / n1}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
