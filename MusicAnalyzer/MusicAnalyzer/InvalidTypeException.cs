using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAnalyzer
{
    class InvalidTypeException : Exception
    {
        string message;
        public override string Message => message;

        public InvalidTypeException()
        {
            message = "Invalid Type";
        }

        public InvalidTypeException(int line, int value, Type desiredType)
        {
            message = $"Invalid type on line {line} value {value}. Must have type of {desiredType}";
        }
    }
}
