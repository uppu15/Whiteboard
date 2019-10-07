using System;

namespace SortStringAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SortString("hello world"));
        }

        public static string SortString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Need input";
            }

            input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if(input[j] > input[j + 1])
                    {
                        char temp = input[j];
                        input = input.Remove(j, 1).Insert(j + 1, temp.ToString());
                    }
                }
            }

            return input;
        }
    }
}
