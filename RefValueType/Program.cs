using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueType
{
    internal class Program
    {
        public static void ChangeRef(ref int number)
        {
            Console.WriteLine($"Inside the ChangeRef method the numberRef is {number}");
            number = 25;
            Console.WriteLine($"Inside the ChangeRef method the numberRef is {number}");
        }
        static void Main(string[] args)
        {
            int numberRef = 15;

            Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
            ChangeRef(ref numberRef);
            Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");
            Console.WriteLine();
        }
    }
}
