using System;

namespace Mirror
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Console.WriteLine(MirrorString("Abcde"));

            Console.WriteLine(ReverseString("Jason"));
        }

        public static string MirrorString(string input)
        {
            char[] stringArray = input.ToCharArray();

            Array.Reverse(stringArray);
            
            return new string(stringArray);
        }

        public static string ReverseString(string input)
        {
            string backward ="";

            for (int i = 0; i < input.Length; i++)
            {

                backward += input[input.Length - i - 1];
            }

            return backward;
        }
    }
}
