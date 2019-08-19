using System;

namespace CountHowManyLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($" {CountChars("                             ")}");

            Console.WriteLine($"{CountLetters("                                ")}");
        }

        public static int CountChars(string input)
        {
            int count = input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    count--;
                }
            }

            return count;
        }

        public static int CountLetters(string input)
        {
            int count = 0;

            //foreach(char c in input)
            //{
            //    if (char.IsLetter(c))
            //    {
            //        count++;
            //    }
            //}

            foreach(char c in input)
            {
                if(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
