using System;

namespace StringExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name : ");
            string fullName = Console.ReadLine();

            int blankPosition = fullName.IndexOf(' ');
            Console.WriteLine(blankPosition);

            string name = fullName.Substring(0, blankPosition);
            string lastName = fullName.Substring(blankPosition + 1);

            Console.WriteLine(lastName);

            Console.WriteLine(name);
        }
    }
}
