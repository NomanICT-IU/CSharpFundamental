using GenralCalculator;
using System;

namespace AnotherAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double result = Calculator.Division(10, 0);
                Console.WriteLine(result);

            }
            catch (DivideByZeroException ex)
            {


                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
