using System;

namespace LogicaltOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 30;
            int c = 20;
            if (a < b && a < c)
            {
                Console.WriteLine($"min number is {a}");
            }
            if (a < b || a < c)
            {
                Console.WriteLine("The a variable is smaller then b or c");
            }
            if (!(a > b))
            {
                Console.WriteLine("a is less than b");
            }
        }
    }
}
