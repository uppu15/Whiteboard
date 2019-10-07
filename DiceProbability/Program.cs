using System;

namespace DiceProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(FindProbability(4));
        }

        public static double FindProbability(int num)
        {
            if (num < 2 || num > 12) return 0;

            int occurance = 0;
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if(i + j == num)
                    {
                        occurance++;
                    }
                }
            }
            double possibility = occurance / 36.0 * 100;
            return possibility; 
        }
    }
}
