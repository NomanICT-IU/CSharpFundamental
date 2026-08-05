using System;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the interger n number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the interger m number:");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (n <= m)
            {
                sum += n;
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
