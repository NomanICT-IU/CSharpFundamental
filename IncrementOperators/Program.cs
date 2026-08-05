using System;

namespace IncrementOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = ++a;
            int c = 20;
            int d = c++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
