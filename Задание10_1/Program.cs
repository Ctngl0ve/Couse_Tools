using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Задание10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(@"Русская 35\1", 34.5, 1990);
            building.DisplayInfo();
            Console.WriteLine("");
            MultiBuilding multiBuilding = new MultiBuilding(@"Казанская 73", 23.8, 2033, 7, true);
            multiBuilding.DisplayInfo();


            //Upcasting - приведение к базовому типу (всегда безопасно).
            Building building1 = multiBuilding;
            Console.WriteLine("\nПосле upcasting:");
            building1.DisplayInfo(); //вызвается переопределнный метод, не потому что он второй, а потому что переопределен

            Console.WriteLine("");

            //  Downcasting - приведение к производному типу
            try
            {
                MultiBuilding multiBuilding1 = (MultiBuilding)building; //должно вылететь
                InvalidExeption(multiBuilding1);
                multiBuilding1.DisplayInfo();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Ошибка приведения: {ex.Message}");
            }

            MultiBuilding multiBuilding2 = building as MultiBuilding; // не должно вылететь (или /var/ вместо  MultiBuilding)
            Console.WriteLine("\nПосле Downcasting:");
            if (multiBuilding2 != null)
            {
                multiBuilding2.DisplayInfo();
            }
            else
            {
                Console.WriteLine("вернуло null");
            }


        }
        static void InvalidExeption(object x)
        {
            Console.WriteLine("Ошибка явного приведения");
        }


        class Building
        {
            protected string _address; //Адрес здания
            protected double _area; //Площадь
            protected int _yearBuilt; //Год постройки
            public int BuildingAge { get; } //Возраст здания в годах

            public Building(string aAr, double bAr, int cAr)
            {
                _address = aAr;
                if (bAr > 0)
                {
                    _area = bAr;
                }
                else
                {
                    Console.WriteLine("Площадь не может быть отрицательна или ровна 0");
                }
                string pattern = @"^(19|20)[0-9][0-9]$";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(cAr.ToString()) && _yearBuilt > DateTime.Now.Year) //ToString для преобразования инта в текст, так как регекс првоеряет текст
                {
                    _yearBuilt = cAr;
                }
                else
                {
                    Console.WriteLine("Ну не может же...");
                }


                BuildingAge = DateTime.Now.Year - _yearBuilt;
            }

            public virtual double CalculateTax()
            {
                double areaNalog = _area * 1000;
                return areaNalog;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Информация о здании\n\nАдрес здания: {_address}\nПлощадь: {_area}\nГод постройки: {_yearBuilt}\nРасчитываемый налог: {CalculateTax()}\nВозраст здания в годах: {BuildingAge}");
            }

        }
        sealed class MultiBuilding : Building
        {
            private int _floors; //количество этажей
            private bool _hasElevator; //наличие лифта

            public double AreaPerFloor { get; }

            public MultiBuilding(string aAr, double bAr, int cAr, int dAr, bool fAr) : base(aAr, bAr, cAr)
            {
                _floors = dAr;
                _hasElevator = fAr;
                if (_floors > 0)
                {
                    AreaPerFloor = _area / _floors;
                }
                else
                {
                    _floors = 1;
                    Console.WriteLine("Вы вывели значение > или = 0,значение этажа указано 1");
                }
            }

            public override double CalculateTax()
            {
                double areaNalog;
                if (_hasElevator == true)
                {
                    areaNalog = (_area * 1000) * (1 + (_floors - 1) * 0.05) + 5000;
                }
                else
                {
                    areaNalog = (_area * 1000) * (1 + (_floors - 1) * 0.05);
                }
                return areaNalog;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo(); //Вызовы метода родителя
                Console.WriteLine($"Наличие лифта: {_hasElevator}\nCредняя площадь на этаж: {AreaPerFloor}");
            }


        }
    }
}



