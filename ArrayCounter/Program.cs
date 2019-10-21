using System;

namespace ArrayCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Count("count this"));
        }

        public static int Count(string input)
        {
            int answer = 0;
            foreach(var x in input)
            {
                answer++;
            }
            return answer;
        }
    }
}
