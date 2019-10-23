using System;

namespace _20191023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Question1());
            Console.WriteLine(Question2());
            Console.WriteLine(Q3());
            Console.WriteLine(Q4());
            Console.WriteLine(Q5());
            Console.WriteLine(Q6());
        }

        public static int Question1()
        {
            int[] z = { 8, 6, 7, 5, 3, 0, 9 };
            int x = int.MaxValue;
            foreach (var y in z) x = y < x ? y : x;

            return x;
        }

        public static int Question2()
        {
            string[] arr =
            {
                "Jenny jenny who can I turn to",
                "You give me something I can hold on to",
                "I know you'll thinkk I'm like the others before",
                "Who saw your name and number on the wall"
            };
            int x = arr[arr.Length - 1].Split(' ')[5].Length;
            return x;
        }

        public static int Q3()
        {
            int[] numbers = new int[] { 8, 6, 7, 5, 3, 0, 9, 8, 6, 7, 5, 3, 0, 9 };
            int x = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    x++;
                }
            }
            return x;
        }

        public static int Q4()
        {
            int x = 867;
            int y = 5309;
            y = x + y;
            x = y - x;
            y = y - x;

            return x;
        }

        public static int Q5()
        {
            int x = 0, y = 8675309;

            while (y > 1)
            {
                x *= 10;
                x += y % 10;
                y /= 10;
            }
            return x;
        }

        public static string Q6()
        {
            string y = "jenny";
            string x = "";

            int j = y.Length;
            for (int i = 0; i < j; i++)
            {
                x += y[j - 1 - i];
            }

            return x;
        }

        public static string GetAcronym(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return "need string";
            }
            if (String.IsNullOrWhiteSpace(input))
            {
                return "can't take whitespaces";
            }
            string output = string.Empty;
            for (int i = 0; i < input.Length-2; i++)
            {
                if(input[i] == ' ')
                {
                    output += input[i + 1];
                }
            }

            return output;
        }
    }
}
