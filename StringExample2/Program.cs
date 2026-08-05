using System;

namespace StringExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence: ");
            string sentence = Console.ReadLine();
            int firstBlankPosition = sentence.IndexOf(' ');

            string withoutFirstWord = sentence.Remove(0, firstBlankPosition + 1);
            int lastBlankPosition = withoutFirstWord.LastIndexOf(' ');
            string withoutFirstAndLast = withoutFirstWord.Remove(lastBlankPosition);
            Console.WriteLine(withoutFirstAndLast);
            Console.ReadKey();
        }
    }
}
