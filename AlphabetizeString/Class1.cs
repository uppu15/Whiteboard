using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizeString
{
    public class Alphabetize
    {
//        public static string Alphabet(string input)
//        {
//            char temp;
//            for (int i = 0; i<input.Length; i++)
//            {
//                for (int j = 0; j<input.Length; j++)
//                {
//                    if (input[j] > input[j + 1])
//                    {
//                        temp = input[j];
//                        input[j] = input[j + 1];
//                        input[j + 1] = temp;
//                    }
//}
//            }
//            return input;
//        }
        public static string SortString(string input)
        {
            string result = string.Empty;

            //foreach (char nextChar in "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz")
            //{
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if(nextChar == char.ToLower(input[i]))
            //        {
            //            result += input[i];
            //        }
            //    }
            //}

            for (char nextChar = 'a'; nextChar <= 'z'; nextChar++)
            { 
                for (int i = 0; i < input.Length; i++)
                {
                    if (nextChar == input[i])
                    {
                        result += nextChar;
                    }
                }          
            }
            return result;
        }
    }
}

