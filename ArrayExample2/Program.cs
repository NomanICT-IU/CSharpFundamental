using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample2
{
    internal class Program
    {
       public static void PrintMin(params int[] numbers)
        {
            int Min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(Min > numbers[i])
                {
                    Min = numbers[i];
                }
            }
            Console.WriteLine(Min);
        }
        static void Main(string[] args)
        {
            PrintMin(49, 58, 10, 98, 47, 13);
            Console.ReadKey();
        }
    }
}
