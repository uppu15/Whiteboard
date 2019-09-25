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
