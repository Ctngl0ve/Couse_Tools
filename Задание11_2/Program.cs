namespace Задание11_2
{
    internal class Program
    {


        //Ну так что, берете такого красавца к себе? Я еще шутить могу, если нужно 







        static void Main(string[] args)
        {
            IFlyable[] flyable = new IFlyable[] { new Bird(500), new Airplane(1000, 10), new Bird(200) };


            Console.WriteLine();
            foreach (var i in flyable)
            {
                i.Fly();
            }
            Console.WriteLine($"Bird: {Bird.Count}");
            Console.WriteLine($"Airplane: {Airplane.Count}");

            Console.ReadKey();
        }
    }



    public interface IFlyable
    {
        void Fly();
        int MaxAltitude { get; }
        void Info();
    }


    public class Bird : IFlyable
    {
        private int _maxAltitude;
        static public int Count { get; set; }
        public int MaxAltitude
        {
            get
            {
                return _maxAltitude;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть отрицательной");
                }
                _maxAltitude = value;
            }
        }
        public Bird(int maxAltitude = 0)
        {
            MaxAltitude = maxAltitude;
            Count++;
        }
        public void Fly()
        {
            Console.WriteLine($"\"Лечу на высоте {MaxAltitude} метров\"");
        }
        public void Info()
        {
            Console.WriteLine($"Количество экземляров класса Bird: {Count}");
        }


    }
    public class Airplane : IFlyable
    {
        private int _maxAltitude;
        static public int Count { get; set; }
        public int MaxAltitude
        {
            get
            {
                return _maxAltitude;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Высота не может быть отрицательной");
                }
                _maxAltitude = value;
            }
        }
        public int CountPassengers { get; set; }
        public Airplane(int maxAltitude = 0, int CountPassengers = 0)
        {
            MaxAltitude = maxAltitude;
            this.CountPassengers = CountPassengers;
            Count++;
        }
        public void Info()
        {
            Console.WriteLine($"Количество экземляров класса Airplane: {Count}");
        }
        public void Fly()
        {
            if (CountPassengers == 0)
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Пассажиров нет");
            }
            else if ((CountPassengers % 10 > 4) && (CountPassengers % 10 <= 9) || (CountPassengers % 10 == 0) || (CountPassengers % 100 > 10) && (CountPassengers % 100 <= 19))
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
            }
            else if ((CountPassengers % 10 > 1) && (CountPassengers % 10 < 5))
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажирa");
            }
            else if (CountPassengers == 1)
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers}го пассажирa");
            }

        }
    }
}
