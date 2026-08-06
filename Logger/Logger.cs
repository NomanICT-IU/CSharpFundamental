using System;

namespace Logger
{
    internal class Logger
    {
        internal string LogMessage(string message)
        {
            return $"Logged at {DateTime.Now}, Message: {message}";
        }
    }
}
