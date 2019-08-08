using System;

namespace IntegerSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IntegerSwap(3, 4);
            IntegerSwap(3, 4);
            IntegerSwap(-1982, -20);
            IntegerSwap(-10, 30);
            IntegerSwap(255, 4);

        }

        public static void IntegerSwap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a},{b}");
        }
    }
}
