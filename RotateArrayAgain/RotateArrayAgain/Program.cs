using System;

namespace RotateArrayAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rotate array using 1 for loop");

            Console.WriteLine(RotateArray("",9));
        }

        //Jaiprakash suggested there is a way to rotate string 'n' times using 1 for loop.
        //I don't think this logic will work using int.
        public static string RotateArray(string input, int n)
        {
            string after = string.Empty;
            string temp = string.Empty;

            if(n == 0)
            {
                return after = input;
            }
            if(input.Length == 0)
            {
                return "No string to rotate";
            }
            if(n >= input.Length)
            {
                n = n % (input.Length - 1);
            }

            for (int i = input.Length - n; i < input.Length; i++)
            {
                temp += input[i];
            }
            input = input.Remove(input.Length - n);

            after = temp + input;

            return after;
        }
    }
}
