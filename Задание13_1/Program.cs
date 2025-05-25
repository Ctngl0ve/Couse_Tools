namespace Задание13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Здравствуйте! Число от 0 до 100 загадано ");

            Random random = new Random();
            int rnd = random.Next(0, 101);

            Console.WriteLine("Введите число:");
            int x;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                i++;
                while (true)
                {
                    if (x == rnd)
                    {
                        Console.WriteLine("Победа");
                        break;
                    }
                    else
                    {
                        if (x < rnd)
                        {
                            Console.WriteLine("Бoльше\nВведите число: ");
                            i++;

                        }
                        else
                        {
                            Console.WriteLine("Меньше\nВведите число: ");
                            i++;
                        }
                    }
                    x = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка! Введено не целочисленное значение");
            }
            finally
            {
                Console.WriteLine($"Число: {rnd}\nПопыток: {i}");
                Console.ReadKey();
            }

        }
    }
}
