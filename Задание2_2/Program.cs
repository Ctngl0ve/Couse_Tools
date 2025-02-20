namespace Задание2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в дюймах для перевода его в метры-сантиметры-миллиметры");
            int DU = Convert.ToInt32(Console.ReadLine());
            const double number_1 = 2.54; // константа дюймов
            double DU_02 = DU * number_1; // введенное значение * на константу и получаем значение в см
            double number_2_MM = DU_02 * 10; // переводим из см (строка выше) в мм 
            int meters = (int)number_2_MM / 1000; // переводим в м 
            int centimeters = ((int)number_2_MM / 10); // переводим в см
            int millimeters = ((int)number_2_MM * 10) % 100; // переводим в мм 
            Console.WriteLine($"Переведем ваше значение выраженое в дюймах {DU} в миллиметры: {number_2_MM}");
            Console.WriteLine($"ИТОГ: Метры = {meters}; Сантиметры = {centimeters}; Миллиметры = {millimeters};");
            Console.ReadLine();
        }
    }
}
