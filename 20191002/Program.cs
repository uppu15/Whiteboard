using System;

namespace _20191002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(Q1());
            //Console.WriteLine(Q2());
            //Console.WriteLine(Q3());
            //Console.WriteLine(Q4());
            //Console.WriteLine(Q5());
            Console.WriteLine(Q6());
        }

        static int Q1()
        {
            int x = 0b01100011;

            return x;
        }

        static int Q2()
        {
            int x = 1;

            do
            {
                x += 10;
            } while (false);

            return x;
        }

        static int Q3()
        {
            int i;
            for (i = 0; i < 10; i++)
            {

            }
            int x = i;
            return x;
        }

        static int Q4()
        {
            int y = 4;
            int x = 2;

            do
            {
                x += y;
            } while (y-- > 1);
            return x;
        }

        static int Q5()
        {
            int x;
            int value1 = 1;

            do
            {
                var Value1 = 'A';
                Console.WriteLine(Value1++);
            } while (value1-- > 0);
            x = value1;

            return x;
        }

        static int Q6()
        {
            int x, y = 55;

            x = y % 10;
            x *= 10;
            x += y / 10;

            return x;
        }
    }
}
