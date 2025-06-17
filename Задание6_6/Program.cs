using System.Text.RegularExpressions;

namespace Задание6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!#;%:?*]).{14,}$"; //?= - "содержит ли" // ^$ - проверить в строке (в слове получается) // [] - диапазон //.* - 0 и более любых значений  

            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                Console.WriteLine($"\\{password}\\ - ok");
            }
            else
            {
                Console.WriteLine($"\\{password}\\ - no ok");
            }
            Console.ReadLine();
            //часть с патерном сделал с ИИ, но сидел долго
        }
    }
}
