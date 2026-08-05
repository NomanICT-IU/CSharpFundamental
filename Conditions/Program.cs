using System;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youe random string: ");
            string testString = Console.ReadLine();

            Console.WriteLine("Choose your color: f for Red, g for Green, and o for Other");
            char color = Convert.ToChar(Console.ReadLine().ToLower());

            if (color == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(testString);
            }
            else if (color == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(testString);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(testString);
            }
            Console.ReadKey();
        }
    }
}
