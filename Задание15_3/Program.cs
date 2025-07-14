namespace Задание15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> email = new HashSet<string>();
            email.Add("alice@example.com");
            email.Add("bob@example.com");
            email.Add("charlie@example.com");

            Console.WriteLine("Подписчики: в 'emale'");
            foreach (string s in email)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----");

            bool dubl = email.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {dubl}");
            Console.WriteLine("-----");

            bool cointanCharlie = email.Contains("charlie@example.com");
            Console.WriteLine($"Есть ли 'charlie@example.com' в подписчиках? {cointanCharlie}");
            Console.WriteLine("-----");

            bool cointanDave = email.Contains("dave@example.com");
            Console.WriteLine($"Есть ли 'dave@example.com' в подписчиках? {cointanDave}");
            Console.WriteLine("-----");

            HashSet<string> newSubscribers = new HashSet<string>();
            newSubscribers.Add("bob@example.com");
            newSubscribers.Add("dave@example.com");
            newSubscribers.Add("eve@example.com");

            bool x1 = newSubscribers.IsSubsetOf(email);
            Console.WriteLine($"'newSubscribers' Является подмножеством? {x1}");
            Console.WriteLine("-----");
            bool y1 = newSubscribers.IsSupersetOf(email);
            Console.WriteLine($"'newSubscribers' Является надмножеством? {y1}");
            Console.WriteLine("-----");

            Console.WriteLine("Подписчики  в 'newSubscribers'");
            foreach (string s in newSubscribers)
            {
                Console.WriteLine($"-{s}");
            }
            Console.WriteLine("-----");


            newSubscribers.UnionWith(email); //Объединение

            Console.WriteLine("Подписчики после объединения 'emale' в 'newSubscribers'");
            foreach (string s in newSubscribers)
            {
                Console.WriteLine($"-{s}");
            }
            Console.WriteLine("-----");

            bool x2 = newSubscribers.IsSubsetOf(email);
            Console.WriteLine($"'newSubscribers' Является подмножеством? {x2}");
            Console.WriteLine("-----");
            bool y2 = newSubscribers.IsSupersetOf(email);
            Console.WriteLine($"'newSubscribers' Является надмножеством? {y2}");
            Console.WriteLine("-----");


            newSubscribers.IntersectWith(email);
            Console.WriteLine("Общие подписчики:");
            foreach (string s in newSubscribers)
            {
                Console.WriteLine($"-{s}");
            }
            Console.WriteLine("-----");


            bool newSubscribersDelite = newSubscribers.Remove("eve@example.com");
            Console.WriteLine($"Удален ли пользователь 'eve@example.com'? {newSubscribersDelite}");
            Console.WriteLine($"Всего подписчиков: {newSubscribers.Count}");
            Console.WriteLine("-----");

            newSubscribers.Clear();
            Console.WriteLine($"Всего подписчиков после обнуления: {newSubscribers.Count}");
            Console.WriteLine("-----");

            Console.ReadKey();
        }


    }
}
