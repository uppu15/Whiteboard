using System;

namespace BrokenPrinter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count how many 'a char' appears in a given string");
        }

        //Dan wants to see how many occurances of a given character is in a given string
        public static int NumChar(string givenString, char givenChar)
        {
            int appearance = 0;
            try
            {
                if (givenString is null)
                {
                    return 0;
                }

                for (int i = 0; i < givenString.Length; i++)
                {
                    if (givenString[i] == givenChar)
                    {
                        appearance++;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("check input");
            }

            return appearance;
        }
    }
}
