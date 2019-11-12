using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAnalyzer
{
    class InvalidNumberOfValuesException : Exception
    {
        private string message = "File formate is invalid";
        public override string Message => message;

        public InvalidNumberOfValuesException(int count, int numberOfValues, int desiredNumberOfValues)
        {
            message = message = $"File formate is invalid on line {count} there are {numberOfValues} values there must be {desiredNumberOfValues}";
        }
    }
}
