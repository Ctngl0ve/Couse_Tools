// Ignore Spelling: Koll Kol

namespace Задание11_1
{
    internal class Program
    {
        static void Main(string[] args)

        //Хотелось бы уточнить, а вот почле курса что нас ожидает? Хотелось бы и дальше изучать и практиковаться, не хотите меня взять к себе в разработчики?а то с каждым разом все интереснее и интереснее 

        // Я же получается могу и тут с вами переписку вести, это что получается - закодированный текст? хехехе 





        //Чтоб использовать конструктор, точнее обратиться к конктретному классу (не через абстрактный) целая история, по факту - если есть абстрактный класс, то практически все методы из всех классов будут переопределены и абстрактны, если же этого не происходит, то значит они задействованы в конструкторе контректного класса, а после все равно идет переопределенный метод; 





        {
            Animal[] animal = [new Dog(), new Dog("Ириска"), new Cat()];

            foreach (var ani in animal)
            {
                ani.ShowInfo();
                ani.ToString();
                Console.WriteLine();
            }
            Console.WriteLine();

            Dog dog = new Dog();
            dog.ToString();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.ToString();

            Console.WriteLine();

            dog.Count();
            cat.Count();

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();

        }
        public abstract void ToString();
        public abstract void Count();
    }
    public class Dog : Animal
    {
        static public int Kol { get; set; }
        public override string Name { get; set; }                /*public override string Name => "Собакен";*/
        public override void Say()
        {
            Console.WriteLine("Гав-Гав");
        }
        public Dog(string name = "Сабакен")
        {
            Name = name;
            Kol++;
        }
        public override void Count()
        {
            Console.WriteLine($"Количество экземпляров {Name}: {Kol}");
        }
        public override void ToString()
        {
            Console.WriteLine($"Экземпляр: {Name}");
        }
    }

    public class Cat : Animal
    {
        static public int Kol { get; set; }
        public override string Name { get; set; }                /*public override string Name => "Собакен";*/
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public Cat(string name = "Киттик")
        {
            Name = name;
            Kol++;
        }

        public override void Count()
        {
            Console.WriteLine($"Количество экземпляров {Name}: {Kol}");
        }
        public override void ToString()
        {
            Console.WriteLine($"Экземпляр: {Name}");
        }

    }
}
