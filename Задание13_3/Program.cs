using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;
using System.Threading;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Channels;

namespace Задание13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
            GameRepite();

        }
        public static void Game()
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===\nВведите имя вашего персонажа :");
            string nameConsole = Console.ReadLine();
            Console.WriteLine(string.IsNullOrWhiteSpace(nameConsole) ? "NULL" : "Имя активировано");
            Console.WriteLine("Введите здоровье вашего персонажа");
            int healthConsole = Convert.ToInt32(Console.ReadLine());

            Character player = new Player(nameConsole, healthConsole, 5);
            Character monster = new Monster();

            Console.WriteLine($"Статистика: Имя: {player.Name}; Здоровье: {player.Health}HP;\n");
            Static();

            int number = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (number == 1)
                {
                    if (player.Health > 0)
                    {
                        if (monster.Health < player.Damage || monster.Health == player.Damage)
                        {
                            monster.Health = 0;
                            Console.WriteLine($"\nПобеда и фанфары");
                            Console.WriteLine($"Здоровье: {player.Health} | {monster.Health} \nЗелий: {((Player)player).Potion}");
                            break;

                        }
                        else if (monster.Health >= player.Damage)
                        {
                            player.Attack(monster);
                        }
                        monster.Attack(player);
                    }
                    else if (player.Health == 0 || player.Health < monster.Damage)
                    {
                        player.Health = 0;
                        Console.WriteLine($"\nПобеда и фанфары, но не у вас ");
                        Console.WriteLine($"Здоровье: {player.Health} | {monster.Health} \nЗелий: {((Player)player).Potion}");
                        break;
                    }
                }
                else if (number == 2)
                {
                    ((Player)player).UseHealthPotion();
                    monster.Attack(player);
                }
                Static();
                number = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static void GameRepite()
        {
            while (true)
            {
                Console.WriteLine($"\nХотите повторить?\n введите true, если да,false, если нет:\n");
                bool repite = Convert.ToBoolean(Console.ReadLine());
                if (repite == true)
                {
                    Game();
                }
                else
                {
                    int x = 1000;
                    Console.WriteLine($"\nСпасибо за игру! Удаление папки System32 через");
                    while (true)
                    {
                        x = x - 1;
                        Console.WriteLine(x);
                    }
                }
            }
        }

        public static void Static()
        {
            Console.WriteLine("Ваш ход: 1 - Атаковать / 2 - Использовать зелье здоровья");
        }
    }
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public virtual void Attack(Character target)
        {
            target.Health = target.Health - this.Damage;
            Console.WriteLine($"Здоровье {target.Name}: {target.Health}НР");

        }


    }
    class Player : Character
    {
        public int Potion { get; private set; } = 3;
        public int HealthPotion { get; } = 10;
        public Player(string name, int health, int damage) : base(name, health, damage)
        {

        }
        public void UseHealthPotion()
        {
            if (Potion > 0)
            {
                Console.WriteLine($"Используем зелье");
                Potion = Potion - 1;
                this.Health = this.Health + HealthPotion;
                Console.WriteLine($"Зельев осталось: {Potion} шт Здоровье: {this.Health}HP (Исцеление на +{HealthPotion}HP)");
            }
            else
            {
                Console.WriteLine($"Зелье кончилось, милорд, дальше только хардкор: {Potion} шт");
            }

        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{this.Name}, атакует и наносит {this.Damage} урона!");
            base.Attack(target);
            Console.WriteLine($"Зелий осталось: {this.Potion}");
        }

    }
    class Monster : Character
    {
        public Monster() : base("Злобный Гоблин", 20, 0)
        {
        }
        public override void Attack(Character target)
        {
            Random random = new Random();
            int randomDamage = random.Next(0, 7);
            this.Damage = randomDamage;
            Console.WriteLine($"{this.Name}, атакует и наносит {this.Damage} урона!");
            base.Attack(target);
        }
    }

}

//  У меня на то провсе ушло дня 3 и полкило нервных клеток, а код ниже написал за куда более короткий период, мы что индусы чтобы нам за количетсво строчек платили

//         while (true)
//            {
//                if (number == 1)
//                {
//                    if (healthGreeenGobline != 0)
//                    {
//                        Console.WriteLine($"{name} наносит 5 урона Злобный Гоблин!");
//                        healthGreeenGobline = healthGreeenGobline - damagePlayer;
//                        Console.WriteLine($"Ход Злобный Гоблин...\n");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"{name} одержал сокрушительную победу.\n");
//                        break;
//                    }
//                }
//                else if (number == 2)
//{
//    Console.WriteLine($"{name} Использует зелье здоровья\n");
//    if (healthPlayer >= 90)
//    {
//        healthPlayer = 100;
//        potion = potion - 1;
//        Console.WriteLine($"Ход Злобный Гоблин...\n");
//    }
//    else
//    {
//        healthPlayer = healthPlayer + healthPotion;
//        potion = potion - 1;
//        Console.WriteLine($"Ход Злобный Гоблин...\n");
//    }

//}
//int damageGreeenGobline = rand.Next(0, 7);
//Console.WriteLine($"Злобный Гоблин наносит {damageGreeenGobline} {name}!");
//healthPlayer = healthPlayer - damageGreeenGobline;
//Console.WriteLine($"Текущее состояние: {name} {healthPlayer}HP Зелье осталось: {potion} шт. \nЗлобный Гоблин: {healthGreeenGobline}HP");

//Console.WriteLine($"Ваш ход: 1 - Атаковать / 2 - Использовать зелье здоровья");
//number = Convert.ToInt32(Console.ReadLine());
//            }





