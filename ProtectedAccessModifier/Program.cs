using System;

namespace ProtectedAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ractangle = new Ractangle(10, 20);

            int area = ractangle.GetArea();
            Console.WriteLine(area);
        }
    }
}
