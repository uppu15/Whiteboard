using System;

namespace PalindromeInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
        }

        
            
        bool isPalindrome(int x)
        {
            string xToString = x.ToString();
            string palindrome = "";

            for (int i = 0; i < (x / 2); i++)
            {
                if(xToString[i] != xToString[xToString.Length -1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
