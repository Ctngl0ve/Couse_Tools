// Ignore Spelling: ints

using System;
using System.Linq;

namespace Задание14_1
{
    internal class Program
    {
        public delegate int Transformer(int x);
        static void Main(string[] args)
        {
            int[] ints = { -5, 2, 3 };
            int[] well1 = Transform(ints, Squaring);
            int[] wel1 = Transform(ints, n => n * n);
            int[] well2 = Transform(ints, Doubling);
            int[] wel2 = Transform(ints, n => n * 2);
            int[] well3 = Transform(ints, Ads);
            int[] wel3 = Transform(ints, n => Math.Abs(n));
            Console.WriteLine(string.Join(",", well1));
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(wel1[i]);
            }
            CW();
            Console.WriteLine(string.Join(",", well2));

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(wel2[i]);
            }
            CW();
            Console.WriteLine(string.Join(",", well3));

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(wel3[i]);
            }
            CW();

            Console.ReadKey();

        }
        public static void CW()
        {
            Console.WriteLine();
        }

        public static int[] Transform(int[] ints, Transformer transformer)
        {
            int i = 0;
            foreach (int x in ints)
            {
                i++;
            }

            int[] result = new int[i];
            int index = 0;
            foreach (int c in ints)
            {
                result[index] = transformer(c);
                index++;
            }
            return result;
        }
        public static int Squaring(int n)
        {
            int result = n * n;
            return result;

        }
        public static int Doubling(int n)
        {
            int result = n * 2;
            return result;
        }
        public static int Ads(int n)
        {
            int result = Math.Abs(n);
            return result;
        }
    }
}
