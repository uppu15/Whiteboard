using System;

namespace HowManyCaps
{
    public class UpperCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tCountCaptials.UpperCase.Main()");
        }
        public static int CountCaps(string sentence)
        {
            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                //char letter = sentence[i]
                if(char.IsUpper(sentence[i]))
                {
                    count++;
                }
            }
            //foreach(char letter in sentence)
            //{
            //    if (char.IsUpper(letter))
            //    {
            //        count++;
            //    }
            //}
            return count;
        }
    }
}
