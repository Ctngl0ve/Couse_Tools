using System.Security.Cryptography.X509Certificates;

namespace Задание13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            const string miniAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            Console.WriteLine("Введите текст:...");
            string x = Console.ReadLine();
            string xConsole = x.Trim();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(xConsole))
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    Console.WriteLine("Любое введенное значение будет расцениваться как строка");
                    break;
                }
                xConsole = Console.ReadLine();
            }
            Console.WriteLine("\nШифрование");
            foreach (char s in xConsole)
            {
                if (char.IsUpper(s))
                {
                    if (alphabet.Contains(s))
                    {
                        int indexNumber = 33 - (alphabet.IndexOf(s) + 1);
                        char indexLetter = alphabet[indexNumber];
                        Console.Write($"{indexLetter}");
                    }
                    else Console.Write(s);
                }
                else
                {
                    if (miniAlphabet.Contains(s))
                    {
                        int indexNumber = 33 - (miniAlphabet.IndexOf(s) + 1);
                        char indexLetter = miniAlphabet[indexNumber];
                        Console.Write($"{indexLetter}");
                    }
                    else Console.Write(s);
                }
            }
            Console.WriteLine("\nДешифрование");
            foreach (char s in xConsole)
            {
                if (char.IsUpper(s))
                {
                    if (alphabet.Contains(s))
                    {
                        int indexNumber = alphabet.IndexOf(s);
                        char indexLetter = alphabet[indexNumber];
                        if (alphabet.Contains(indexLetter))
                        {
                            int indexNumberRepite = alphabet.IndexOf(indexLetter);
                            char indexLetterRepite = alphabet[indexNumberRepite];
                            Console.Write($"{indexLetterRepite}");
                        }
                        else Console.Write(s);
                    }
                    else Console.Write(s);
                }
                else
                {
                    if (miniAlphabet.Contains(s))
                    {
                        int indexNumber = miniAlphabet.IndexOf(s);
                        char indexLetter = miniAlphabet[indexNumber];
                        if (miniAlphabet.Contains(indexLetter))
                        {
                            int indexNumberRepite = miniAlphabet.IndexOf(indexLetter);
                            char indexLetterRepite = miniAlphabet[indexNumberRepite];
                            Console.Write($"{indexLetterRepite}");
                        }
                        else Console.Write(s);
                    }
                    else Console.Write(s);
                }
            }
            Console.WriteLine("\n\nСпасибо за внимание, мне легче решить следующее задание и написать 150+ строк, чем работать со строками...");
            Console.ReadLine();
        }

    }
}
