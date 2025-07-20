using System.Text;

namespace Задание6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); //конструктор 

            Console.WriteLine("Введите Имя:  ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город:  ");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст:  ");
            string age = Console.ReadLine();
            sb.Append(name);
            Console.Write($" Имя: {sb.ToString()}");
            sb.Replace(name, city);
            Console.Write($" Город: {sb.ToString()}");
            sb.Replace(city, age);
            Console.Write($" Возраст: {sb.ToString()}");
            Console.ReadKey();
        }
    }
}
