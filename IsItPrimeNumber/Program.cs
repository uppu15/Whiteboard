using System;

namespace IsItPrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See if given number is prime number.");
        }

        public static bool isPrimeNumber(int input)
        {
            if (input < 2)
            {
                return false;
            }
            for (int i = 2; i < input; i++)
            {
                if ((input % i) == 0)
                    return false;
            }
            return true;
        }
        
    }
}
