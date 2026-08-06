using System;

namespace GenralCalculator
{
    /// <summary>
    /// This is a general calculator
    /// </summary>
    public static class Calculator
    {
       /// <summary>
       /// The Add method perform adding 2 numbers
       /// </summary>
       /// <param name="firstNumber">This is first nmber</param>
       /// <param name="secondNumber">This is second number</param>
       /// <returns></returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Subtruction(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double result=firstNumber * secondNumber;
            return result;
        }

        public static double Division(double firstNumber, double secondNumber)
        {
           
            if (secondNumber== 0)
            {
                throw new DivideByZeroException(message: "Second number must be greater then zero");
            }
            double result = firstNumber / secondNumber;
             return result;
           
     
        }
    }
}
