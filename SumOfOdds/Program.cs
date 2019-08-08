using System;

namespace SumOfOdds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
        }
        public static int SumOfOdds(int x)
        {
            //  while(x > 0)
            //    {
            //    if(x % 2 == 1)
            //    {
            //       x -= x - 2;
            //        }
            //        else
            //        {
            //            x++;
            //        }
            //    }
            //return x;

            int total = 0;
            for(int i=0; i<=x; i++)
            {
                if (i%2 ==1)
                {
                    total += i;
                }
            }
            return total;
        }
        
    }
}
