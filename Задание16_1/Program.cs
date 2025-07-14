using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Задание16_1

    //очень странно, но я думал, что уже отправил это на хаб, какая-то шизофрения...и теперь у меня проблемы с этими репозиториями со всеми...
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
             new Computer () { _id= 1, _name ="hp", _processorName ="AA-11", _processorFrequency = 220, _rAM =4,_hardDisk = 256, _videoCardMemory = 32,_cost =  15000,_quantity = 1 },
             new Computer () { _id= 2, _name ="hp", _processorName ="Ryzen 9800", _processorFrequency = 220, _rAM =8,_hardDisk = 128, _videoCardMemory = 32,_cost = 25000,_quantity = 15 },
             new Computer () { _id= 3, _name ="Apple", _processorName ="M-1", _processorFrequency = 220, _rAM =16,_hardDisk = 256, _videoCardMemory = 32,_cost =  15000,_quantity = 1 },
             new Computer () { _id= 4, _name ="samsung", _processorName ="Intel Core 8", _processorFrequency = 220, _rAM =32,_hardDisk = 256, _videoCardMemory = 32,_cost=  15000,_quantity = 7 },
             new Computer () { _id= 5, _name ="lenovo", _processorName ="AA-55", _processorFrequency = 220, _rAM =16,_hardDisk = 256, _videoCardMemory = 32,_cost = 39000,_quantity = 2 },
             new Computer () { _id= 6, _name ="asus", _processorName ="Ryzen 7800", _processorFrequency = 220, _rAM =8,_hardDisk = 256, _videoCardMemory = 32,_cost =  69000,_quantity = 1 },
             new Computer () { _id= 7, _name ="samsung", _processorName ="AA-1", _processorFrequency = 220, _rAM =4,_hardDisk = 256, _videoCardMemory = 32,_cost =  65000,_quantity = 1 },
             new Computer () { _id= 8, _name ="Apple", _processorName ="M-4", _processorFrequency = 220, _rAM =32,_hardDisk = 256, _videoCardMemory = 32,_cost =  49000,_quantity = 4 },
             new Computer () { _id= 9, _name ="asus", _processorName ="Ryzen 7800", _processorFrequency = 220, _rAM =8,_hardDisk = 256, _videoCardMemory = 32,_cost=  14000,_quantity = 1 },
             new Computer () { _id= 10, _name ="lenovo", _processorName ="Intel Core 8", _processorFrequency = 220, _rAM =8,_hardDisk = 128, _videoCardMemory = 32,_cost =  5000,_quantity = 2 },
             new Computer () { _id= 11, _name ="Apple", _processorName ="M-2", _processorFrequency = 220, _rAM =32,_hardDisk = 128, _videoCardMemory = 32,_cost =  70000,_quantity = 5 },

            };


            Console.WriteLine();
            Console.WriteLine("-все компьютеры с указанным процессором. Название процессора запросить у пользователя;");
            Console.WriteLine("Ввод");
            Console.WriteLine();


            string processorNameCW = Console.ReadLine();

            var processorName = list
                .Where(x => x._processorName == processorNameCW)
                .ToList();

            foreach (var x in processorName)
            {
                Console.WriteLine($" Id: {x._id} \\ Модель: {x._name} \\ ОЗУ: {x._rAM} \\Диск: {x._hardDisk} \\ Цена: {x._cost} \\ В наличии: {x._quantity}");
            }

            Console.WriteLine();
            Console.WriteLine("-все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;");
            Console.WriteLine("Ввод");
            Console.WriteLine();

            int ramCW = Convert.ToInt32(Console.ReadLine());

            var RAM = list
            .Where(x => x._rAM > ramCW)
            .ToList();

            foreach (var x in RAM)
            {
                Console.WriteLine($" Id: {x._id} \\ Модель: {x._name} \\ ОЗУ: {x._rAM} \\Диск: {x._hardDisk} \\ Цена: {x._cost} \\ В наличии: {x._quantity}");
            }



            Console.WriteLine();
            Console.WriteLine("-вывести весь список, отсортированный по увеличению стоимости;");
            Console.WriteLine();

            var costOrder = list
            .OrderBy(x => x._cost)
            .ToList();
            foreach (var x in costOrder)
            {
                Console.WriteLine($" Цена: {x._cost} \\ Id: {x._id} \\ Модель: {x._name} \\ ОЗУ: {x._rAM} \\Диск: {x._hardDisk} \\ В наличии: {x._quantity}");
            }

            Console.WriteLine();
            Console.WriteLine("-вывести весь список, сгруппированный по типу процессора; только для наглядности вывел по озу");
            Console.WriteLine();

            var ramGroup = list
            .GroupBy(x => x._rAM)
            .ToList();
            foreach (var ramGroups in ramGroup)
            {
                foreach (var x in ramGroups)
                {
                    Console.WriteLine($" ОЗУ: {x._rAM} - ID: {x._processorName} - ID: {x._id}");
                }
            }


            Console.WriteLine();
            Console.WriteLine("- найти самый дорогой и самый бюджетный компьютер;");
            Console.WriteLine();

            var costMax1 = list
                .Max(x => x._cost);

            Console.WriteLine($"Цена (самый дорогой): {costMax1}");

            var costMax2 = list
                .OrderBy(x => x._cost)
                .LastOrDefault();
            Console.WriteLine($"Цена (самый дорогой): {costMax2._cost} ID: {costMax2._id} Имя: {costMax2._name} В наличии : {costMax2._quantity}");

            var costMin1 = list
           .Min(x => x._cost);

            Console.WriteLine($"Цена (самый бюджетный): {costMin1}");

            var costtMin2 = list
                .OrderBy(x => x._cost)
                .FirstOrDefault();
            Console.WriteLine($"Цена (самый бюджетный): {costtMin2._cost} ID: {costtMin2._id} Имя: {costtMin2._name} В наличии : {costtMin2._quantity}");

            Console.WriteLine();
            Console.WriteLine("- есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine();

            var quantity = list
               .Any(x => x._quantity > 30);
            Console.WriteLine(quantity);


            Console.ReadKey();

        }
    }


    public class Computer

    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _processorName { get; set; }
        public int _processorFrequency { get; set; }
        public int _rAM { get; set; }
        public int _hardDisk { get; set; }
        public int _videoCardMemory { get; set; }
        public int _cost { get; set; }
        public int _quantity { get; set; }
    }


}
