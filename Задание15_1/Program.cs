using System;

namespace Задание15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lastName = new List<string> { "Петров", "Сидоров" };
            lastName.Add("Иванов");

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < lastName.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lastName[i]}");
            }
            Console.WriteLine();

            lastName.Insert(1, "Козлов");

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < lastName.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lastName[i]}");
            }
            Console.WriteLine();

            bool petrovLastName = lastName.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {petrovLastName}");


            bool sidorovLastNameDelite = lastName.Remove("Сидоров");


            int kozlovLastName = lastName.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {kozlovLastName}");

            lastName.Sort();

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < lastName.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lastName[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Команда пуста?");

            bool team = true;
            if (lastName.Count > 0)
            {
                team = false;
                Console.WriteLine(team);
            }
            else
            {
                Console.WriteLine(team);
            }

            lastName.Clear();

            Console.WriteLine($"Количество игроков после очистки: {lastName.Count}");

            Console.ReadKey();
        }



    }
}
