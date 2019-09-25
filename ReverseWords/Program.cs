using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20190911 Technical mentor group session");
        }

        //20190911 reverse string
        //input should be no more than 100 words
        //session decided that space = word
        public static string ReverseWord(string input)
        {
            string backward = string.Empty;
            int wordCount = 0;
            if (String.IsNullOrEmpty(input))
            {
                return "Need input";
            }


            for (int i = input.Length - 1; i >= 0; i++)
            {
                if (input[i] == ' ')
                {
                    wordCount++;
                }
                if (wordCount > 100)
                {
                    return "Too many words";
                }
                backward += input[i];
            }

            return backward;
        }

        //reverse string without declaring a new variable ( use temp char )
        public static string ReverseWordWithNoOtherString(string input)
        {

            if (String.IsNullOrEmpty(input))
            {
                return "Need input";
            }

            for (int i = 0; i < (int)(input.Length / 2); i++)
            {
                int wordCount = 0;
                char tempChar = '';

                if (input[i] == ' ')
                {
                    wordCount++;
                }
                if (wordCount > 100)
                {
                    return "Too many words";
                }

                input[i] = tempChar;
                input[input.Length - 1 - i] = input[i];
            }

            return input;
        }
    }
}
