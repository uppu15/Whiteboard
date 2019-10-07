using System;
using System.Collections.Generic;

namespace StackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Q());
            Console.WriteLine(q7());
            suddenQ();
            Console.WriteLine(Q8());
            Console.WriteLine(Q9());
            Console.WriteLine(Q10());
            Console.WriteLine(Q11());
            queryColon();
        }

        //Dan's questions
        static void suddenQ()
        {
            int m = 4;
            int n = m;

            n = ++m;
            m = n++;

            Console.WriteLine(m + "and " +n);
        }

        static int Q()
        {
            int y = 5;
            int x = 1;
            do
            {
                x += y;

            } while (y-- > 1);

            return x;
        }

        static bool q7()
        {
            bool x;
            int a = 4;
            int b = 4;
            a = ++a;
            b = b & 1;

            x = (a == b);

            return x;
        }

        static int Q8(int x =5)
        {
            int y = 2;
            if(x > y)
            {
                x %= y;
                Q8(x);
            }

            return x;
        }

        static int Q9()
        {
            int x = 0;
            int y = 5;

            for (int i  = y; i  > 0; i --)
            {
                x += (i % 2 == 1) ? i : y;
            }
            return x;
        }

        static int Q10()
        {
            int x = 0;
            int y = 3;
            bool isTrue = true;

            while (!isTrue)
            {
                x += ++y;
                if( x >= 12)
                {
                    isTrue = (!false);
                }
            }
            return x;
        }

        static int Q11()
        {
            string string1 = "Mississippi";
            string string2 = "";

            foreach(var s in string1.Split('i'))
            {
                string2 += s;
            }
            int x = string2.Length;

            return x;
        }

        static void queryColon()
        {
            bool haveTime = true;
            string Answer = haveTime ? "yes" : "no";

            Console.WriteLine($"Can we? {Answer}");
        }
    }

    public class PlayWithStack
    {
        public static Stack<int> PushStack(int lastIn, Stack<int> thisStack)
        {
            int maxStackCount = 5;
            if (thisStack.Count < maxStackCount)
            { 
                thisStack.Push(lastIn);
            }
            else
            {
                Console.WriteLine("Cannot take more than 5.");
            }

            return thisStack;
        }

        public static Stack<int> PopStack(int lastOut, Stack<int> thisStack)
        {
            thisStack.Pop();

            return thisStack;
        }

        public static void PrintStack(Stack<int> thisStack)
        {
            foreach(int x in thisStack)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
