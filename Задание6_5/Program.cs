using System.Text.RegularExpressions;

namespace Задание6_5
{
    internal class Program
    {
        static void Main(string[] args)
        
        {   
            Console.WriteLine("Введите номер телефона:  ");
            string number = Console.ReadLine();
            string pattern = @"^\+[7]\([0-9]{3}\)[ \-][0-9]{3}[ \-][0-9]{2}[ \-][0-9]{2}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(number))
            {
                Console.WriteLine($"\\{number}\\ - Введен верный номер телефона");
            }
            else
            {
                Console.WriteLine($"\\{number}\\ - Прошу введите номер телефона, имеющий форму: +7(...)...-..-..");
            }
            Console.ReadKey();
        }
    }
}
