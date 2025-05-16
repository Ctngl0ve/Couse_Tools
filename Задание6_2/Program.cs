using System;
using System.Text.RegularExpressions;

namespace Задание6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение (слова, разделенные собой пробелом), Прошу не использовать знаки препинания: ");
            string pol = Console.ReadLine();
            //int dlina = 0;
            //string stroka = " ";

            for (int i = 0; i < pol.Length; i++)
            {
                pol = pol.Replace(",", "");
                pol = pol.Replace(".", "");
                pol = pol.Replace("?", "");
                pol = pol.Replace("!", "");
                pol = pol.Replace("\"", "");
                pol = pol.Replace("$", "");
                pol = pol.Replace("^", "");
                pol = pol.Replace("&", "");
                pol = pol.Replace("(", "");
                pol = pol.Replace(")", "");
                pol = pol.Replace("-", "");
                pol = pol.Replace("_", "");
                pol = pol.Replace(" ", "");
                pol = pol.ToLower();
            }
            pol = pol.Trim();
            Console.WriteLine(pol);
            for (int i = 0; i < pol.Length / 2; i++)
            {
                if (pol[i] == pol[pol.Length - 1 - i])
                {
                    Console.WriteLine("палиндром");
                }
                else
                {
                    Console.WriteLine("Увы, вы проиграли");
                }
            }
            Console.ReadKey();
            //часть с циклом сделал с ИИ


        }
    }
}
