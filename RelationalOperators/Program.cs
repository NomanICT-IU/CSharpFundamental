using System;

namespace RelationalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 15;
            string s1 = "This is a string";
            string s2 = "This is a string";
            var student1 = new Student("John", 25);
            var student2 = new Student("John", 25);
            Console.WriteLine(a == b);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(student1 == student2);
        }
    }
}
