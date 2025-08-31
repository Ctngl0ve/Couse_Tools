using System.Data;

namespace Задание8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Прошу по порядку вести числа- \nВведите первое число: \nВведите второе число: \nВведите код операции (1|2|3|4): ");
            try
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int cod = Convert.ToInt32(Console.ReadLine());
                Code(cod);
                Console.WriteLine(cod);
                if (cod == 1)
                {
                    int resultSum = Sum(x1, x2);
                    Console.WriteLine($"Ваш результат: {resultSum} Код: {cod}  - сумма");
                }
                else
                {
                    if (cod == 2)
                    {
                        int resultDifference = Difference(x1, x2);
                        Console.WriteLine($"Ваш результат: {resultDifference} Код: {cod}  - разность");
                    }
                    else
                    {
                        if (cod == 3)
                        {
                            int resultProduct = Product(x1, x2);
                            Console.WriteLine($"Ваш результат: {resultProduct} Код: {cod}  - произведение");
                        }
                        else
                        {
                            int resultDivision = Division(x1, x2);
                            Console.WriteLine($"Ваш результат: {resultDivision} Код: {cod}  - деление");
                        }
                    }
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка! Деление на 0! {ex.ToString()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка! Введено не число! {ex.ToString()}"); 
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Выходит за допустимое значение");
            }

            Console.ReadKey();

            static void Code(int cod)
            {
                if (cod < 1 || cod > 4)
                    throw new ArgumentException($"Код операции выходит за пределы допустимого значения: {cod} ");
            }//аргумент исключения должен быть таким же как и в методе
            static int Sum(int x, int y) => x + y;
            static int Difference(int x, int y) => x - y;
            static int Product(int x, int y) => x * y;
            static int Division(int x, int y) => x / y;

        }
    }
}
