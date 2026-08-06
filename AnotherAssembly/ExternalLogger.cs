namespace AnotherAssembly
{
    public class ExternalLogger
    {
        public void ExternalLogMessage(string message)
        {
            var logger = new Logger.Logger();
            logger.LogMessage(message);
        }
    }
}
