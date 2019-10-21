using System;

namespace _20191009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Q1());
            Console.WriteLine(Q2());
            Console.WriteLine(dwarf());
        }

        static int Q1()
        {
            int y = 3;
            int x = 3;
            do
            {
                x += y;
            } while (y-- > 1);

            return x;
        }

        static bool Q2()
        {
            bool x;
            int a = 6;
            int b = 3;

            a = ++a;
            b = b & 1;

            x = (a == b);

            return x;
        }

        static string dwarf()
        {
            int happy;
            var hi = true;
            string[] dwarf = { "0:>", ":{", "x)", ":)", "|<", ":|", ":/" };

            for(happy = 0; happy < dwarf.Length; happy++)
            {
                bool ho = !(hi);
                hi = ho;
            }

            var x = dwarf[happy / 2] == ":)" ? "hi" : "ho!";
            return x;
        }
    }

    public delegate string DelegateThis(string delString);

    class DelEvent
    {
        event DelegateThis thisEvent;

        public DelEvent()
        {
            this.thisEvent += new DelegateThis(this.HelloWorld);
        }
        public string HelloWorld(string name)
        {
            return "Hello" + name + "'s World";
        }

        static void Main(string[] args)
        {
            DelEvent example = new DelEvent();
            string returnedString = example.thisEvent("June");
            Console.WriteLine(returnedString);
        }
    }

    class FuncActPredicate
    {
        static void Main(string[] args)
        {
            Action<int> fromHexToIntAct = delegate (int integer)
            {
                Console.WriteLine(integer.ToString("X"));
            };

            fromHexToIntAct(16);

            Func<int, string> fromHexToIntFunc = delegate (int integer)
            {
                return (integer.ToString("X"));
            };
            Console.WriteLine(fromHexToIntFunc(16));
        }
    }
}
