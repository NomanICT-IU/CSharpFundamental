using System;

namespace NestedConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int printedNumber;
            if (number > 50)
            {
                if (number % 2 == 0)
                {
                    printedNumber = number * 2;
                }
                else
                {
                    printedNumber = number * 3;
                }
            }
            else
            {
                printedNumber = number * 5;
            }
            Console.WriteLine(printedNumber);

            Console.ReadKey();
        }
    }
}
