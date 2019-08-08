using System;

namespace Relativity
{
    class Program
    {
        static string Relativity()
        {
            // TODO: prove theory of relativity as demonstrated.
            return "\n\tProven";
        }

        static void TestRelativity()
        {
             Console.WriteLine(Relativity());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\nRelativity.Main()\n");
            TestRelativity();
        }
    }
}
