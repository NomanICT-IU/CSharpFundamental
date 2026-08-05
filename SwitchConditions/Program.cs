using System;

namespace SwitchConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month number from 1 to 12:");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Number of Days is 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Number of Days is 30");
                    break;
                case 2:
                    Console.WriteLine("Number of Days is 28 or 29");
                    break;
                default:
                    Console.WriteLine("Your number is not between 1 to 12");
                    break;
            }

        }
    }
}
