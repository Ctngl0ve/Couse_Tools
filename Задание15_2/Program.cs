namespace Задание15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> store = new Dictionary<string, int>();
            store.Add("А001", 10);
            store.Add("B205", 25);
            store.Add("C307", 15);

            Console.WriteLine("----");

            Console.WriteLine("Текущий инвентарь: ");
            foreach (var key in store)
            {
                Console.WriteLine($"Артикул: {key.Key}, Количество: {key.Value}");

            }
            Console.WriteLine($"Общее число: {store.Count}");
            Console.WriteLine("----");
            bool phoneStore = store.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {phoneStore}");
            Console.WriteLine("----");
            store["А001"] = 8;

            Console.WriteLine("Текущий инвентарь: ");
            foreach (var key in store)
            {
                Console.WriteLine($"Артикул: {key.Key}, Количество: {key.Value}");

            }
            Console.WriteLine("----");
            if (store.TryGetValue("C307", out int coint))
            {
                Console.WriteLine($"Количество наушников (id C307) : {coint}");
            }
            Console.WriteLine("----");
            store["B205"] = 30;

            bool storeRemove = store.Remove("C307");

            Console.WriteLine("Текущий инвентарь: ");
            foreach (var key in store)
            {
                Console.WriteLine($"Артикул: {key.Key}, Количество: {key.Value}");

            }
            Console.WriteLine("----");
            bool team = true;
            if (store.Count > 0)
            {
                team = false;
                Console.WriteLine($"Инвентарь пуст? {team}");
            }
            else
            {
                Console.WriteLine($"Инвентарь пуст? {team}");
            }

            store.Clear();
            Console.WriteLine("----");
            Console.WriteLine($"Количество товаров после очистки: {store.Count}");
            Console.ReadKey();
        }
    }
}
