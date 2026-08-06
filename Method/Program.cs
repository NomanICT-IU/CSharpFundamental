using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Program
    {
        public static void Sum(int first, int second)
        {
            int result = first + second;
            Console.WriteLine(result);
        }
        public static void Subtract(int first, int second)
        {
            int result = first - second;
            Console.WriteLine(result);

        }
        public static void Multiply (int first, int second)
        {
            int result = first * second;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            int firstArgument = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondArgument = Convert.ToInt32(Console.ReadLine());

            Sum(firstArgument, secondArgument);
            Subtract(firstArgument, secondArgument);
            Multiply(firstArgument, secondArgument);
        }
    }
}
