using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutValueType
{
    internal class Program
    {
        public static void ChangeOut(out int numberOut)
        {
            numberOut = 25;
            Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
        }
        static void Main(string[] args)
        {
            int numberOut;
            Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
            ChangeOut(out numberOut);
            Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
            
            Console.ReadKey();
        }
    }
}
