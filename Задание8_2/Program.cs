namespace Задание8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Вне диопазона!\n{ex.Message}"); //без этого Message он не будет выводить сообщение из метода
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ведите число!\n{ex.ToString()}");
            }
            Console.ReadKey();

            static void ValidateAge(int age)
            {
                int maxAge = 150;
                if (age <= 0)
                    throw new ArgumentException("Возраст не может быть отрицательным или равен 0");
                if (age > maxAge)
                    throw new ArgumentException("Слишком большой возраст");
            }
        }
    }
}
