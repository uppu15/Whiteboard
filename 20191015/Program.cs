using System;

namespace _20191015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20191015");
            Console.WriteLine(Q1());
            Console.WriteLine(Q2());
            Console.WriteLine(Q3());
            Console.WriteLine(Q4());
        }

        static int Q1()
        {
            int[] z = { -99, 0, 1, 2, 3, 5, 8, 13, 21, 34 };
            int x = int.MaxValue;
            foreach (var y in z) x = y < x ? y : x;

            return x;
        }

        static int Q2()
        {
            string[] arr = { "the", "quick", "brown", "fox" };
            int x = arr[arr.Length - 1].Length;

            return x;
        }

        static int Q3()
        {
            int x = 0b1111 & 0xFF;

            return x;
        }

        static string Q4()
        {
            string y = "mbilg";
            string x = "";
            for (int i = 0; i < y.Length; i++)
            {
                x += Convert.ToChar(y[i] - i);
            }
            return x;
        }
    }
}
