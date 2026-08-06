using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    internal class Program
    { 
        public static void PopulateArray(int[] numbers)
        {
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101);
                Console.WriteLine($"The {i+1} element is: {numbers[i]}");
            }
        }
        public static void CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum+= item;
            }
            Console.WriteLine($"The sum of all Element is: {sum}");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the array Capacity:");
            int capacity = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[capacity];
            PopulateArray(numbers);
            Console.WriteLine();
            CalculateSum(numbers);

            Console.ReadKey();
        }
    }
}
