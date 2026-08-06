using System;

namespace PublicAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int value = calculator.Value = 10;
            int incrementedValue = calculator.IncrementValue(value);
            Console.WriteLine(incrementedValue);
        }
    }
}
