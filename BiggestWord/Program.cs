using System;

namespace BiggestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20190813");


            Console.WriteLine($"{biggerWordSuggestion("This is not itllll")}");
            Console.WriteLine($"{biggerWordSuggestion("12345 789 101112 13141516")}");
            Console.WriteLine($"{biggerWordSuggestion("      1234     56789")}");
            Console.WriteLine($"{biggerWordSuggestion("               ")}");
            Console.WriteLine($"{biggerWordSuggestion("asldf;adskf;jadf")}");
            Console.WriteLine($"{biggerWordSuggestion("")}");
        }

        static bool bigWordMySolution(string input)
        {
            string[] eachWord = input.Split();
            string biggerWord = "";

            if (eachWord.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (eachWord[i].Length > eachWord[i - 1].Length)
                { 
                    biggerWord = eachWord[i];
                }
            }

            return true;
        }

        static bool biggerWordSuggestion(string word)
        {
            string result = "", currWord = "";
            int maxi = 0, count = 0;

            if (word.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    count++;
                    currWord += word[i];
                }
                else
                {
                    if (count > maxi)
                    {
                        result = currWord;
                    }
                    count = 0;
                    currWord = "";
                }
                if(count > maxi)
                {
                    result = currWord;
                }
            }

            Console.WriteLine(result);
            return true;
        }
    }
}
