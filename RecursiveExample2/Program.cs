using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExample2
{
    internal class Program
    {
        public static int CountDivision(int number)
        {
            int count = 0;
            if(number > 0 && number % 2 == 0)
            {
                count++;
                number /= 2;
                return count += CountDivision(number);
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = CountDivision(number);

            Console.WriteLine(result);
        }
    }
}
