using System;

namespace Logger.Exceptions
{
    public class InvalidLayoutTypeException : Exception
    {
        private const string EXC_MESSAGE = "Invalid Layput Type!";
        public InvalidLayoutTypeException()
            : base(EXC_MESSAGE)
        {
            
        }

        public InvalidLayoutTypeException(string message) 
            : base(message)
        {

        }
    }
}