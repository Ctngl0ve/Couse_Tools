using System.Runtime.CompilerServices;

namespace Задание9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            try
            {


                for (int i = 0; i < numbers.Length; i++)
                {
                    var numberShet = new BankAccount(numbers[i]);
                    numberShet.ReaLine();
                    Console.WriteLine();
                    for (int j = 1; j <= 1; j++)
                    {
                        Console.WriteLine("Хотите пополнить счет?");
                        bool yesOrNo1 = Convert.ToBoolean(Console.ReadLine());
                        if (yesOrNo1 == true)
                        {
                            Console.WriteLine("Укажите количество денежных средств");
                            decimal amounts = Convert.ToDecimal(Console.ReadLine());
                            numberShet.Deposit(amounts);
                        }
                        Console.WriteLine("Хотите cнять со счета?");
                        bool yesOrNo2 = Convert.ToBoolean(Console.ReadLine());
                        if (yesOrNo2 == true)
                        {
                            Console.WriteLine("Укажите количество денежных средств");
                            decimal amounts = Convert.ToDecimal(Console.ReadLine());
                            Argument(amounts);
                            numberShet.Withdraw(amounts);
                        }
                    }
                    numberShet.Tire();
                    numberShet.Text();
                    numberShet.Tire();
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }

        static void Argument(decimal ex)
        {
            if (ex < 0)
                throw new ArgumentException("Введено отрицательное значение");
        }


    }

    class BankAccount
    {
        private static int TotalAccounts = 0; //общее количество созданных счетов
        //private int accountNumber; //номер счета
        //private static decimal _balance; //баланс счета

        public static decimal Balance { get; private set; }


        public int AccountNumber { get; } //или readonly - только для чтения, задается в конструкторе


        public BankAccount(int numberAccount)
        {
            Random random = new Random();
            Balance = random.Next(0, 1000);
            numberAccount = random.Next(999, 999999);
            AccountNumber = numberAccount;
            TotalAccounts++;
        }

        public void Deposit(decimal amount) //пополняет баланс
        {
            Balance += amount;
            Console.WriteLine($"Ваш баланс {Balance}");
        }
        public void Withdraw(decimal amount) // снимает баланс
        {
            if (Balance > amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
            Console.WriteLine($"Ваш баланс {Balance}");
        }

        public void ReaLine()
        {
            Console.WriteLine($"Ваш номер счета: {AccountNumber}\nВаш баланс: {Balance} р.");
        }

        public void Text()
        {
            Console.WriteLine($"Количество счетов: {TotalAccounts}");
        }
        public void Tire()
        {
            string tire = new String('-', 40);
            Console.WriteLine(tire);
        }





    }
}
