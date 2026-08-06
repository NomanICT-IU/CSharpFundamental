using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyValue
{
    internal class Program
    {
        public static void ChangeAndWrite(int number)
        {
            number = 10;
            Console.WriteLine($"Inside change and write method, number value is: {number}");
        }
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Inside main method, number value is: {number}");
            ChangeAndWrite(number);
            Console.WriteLine($"Inside  main method after the ChangeAndWrite call, , number value is: {number}");
            Console.ReadKey();
        }
    }
}
