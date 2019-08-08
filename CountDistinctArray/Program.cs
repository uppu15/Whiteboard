using System;

namespace CountDistinctArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = { 1, 2, 3, 3, 3 };
            Console.WriteLine(CountDistinctElements(input));

        }

        public static int CountDistinctElements(int[] given)
        {
            int count = 0;
            int j;
            for (int i = 0; i < given.Length; i++)
            {
                bool isDuplicate = true;

                for (j = 0; j < i; j++)
                {
                    if (given[i] == given[j])
                    {
                        isDuplicate = false;
                        break;
                    }

                }
                if (isDuplicate)
                {
                    count++;
                }
            }     
            return count;
        }

    }
}

