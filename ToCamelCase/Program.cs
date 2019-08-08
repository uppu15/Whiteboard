using System;

namespace ToCamelCase
{
    public class CamelCaseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn a string to CamelCase");

            Console.WriteLine(camelCase("a wOndeRful life"));

            Console.WriteLine(toCamelCase("SDFLK:j FOPSDIU EFISEFi"));
            
        }

        public static string camelCase(string input)
        {
            string lowerInput = input.ToLower();

            char[] array = lowerInput.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsUpper(array[0]))
                {
                    array[0] = char.ToLower(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        
        public static string toCamelCase(string inputString)
        {
            string camelCaseString = "";
            
            inputString = inputString.ToLower();

            for (int i = 0; i < inputString.Length; i++)
            {
                char nextChar = inputString[i];

                while (!char.IsLetter(nextChar))
                {
                    nextChar = char.ToUpper(inputString[++i]);
                }
                camelCaseString += nextChar;
            }

            return camelCaseString;
        }
    }
}
