using System;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var messageLog = logger.LogMessage("This is a message");
            Console.WriteLine(messageLog);
        }
    }
}
