using System;

namespace ExceptionHandling
{
    internal class InvalidUserIdException : Exception
    {
        public static void ValidateId(int id)
        {
            if (id < 0 || id > 1000)
            {
                throw new InvalidUserIdException();
            }
        }
    }
}
