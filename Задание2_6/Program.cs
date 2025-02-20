namespace Задание2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится длина трубы в метрах. Округлить длину до 0,5
            Console.WriteLine("Введите число: Например: 17,02");
            decimal nu_01 = Convert.ToDecimal(Console.ReadLine());
            decimal e = (Math.Round(nu_01));
            
            // скорее всего тут нужно что-то дальше, пока не могу понять
            Console.WriteLine($"Округленное значение:{e}");
            Console.ReadLine();
        }
    }
}
