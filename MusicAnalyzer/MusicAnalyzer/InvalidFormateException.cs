using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAnalyzer
{
    class InvalidFormateException : Exception
    {
        private string message = "File formate is invalid";
        public override string Message => message;

        public InvalidFormateException(int count)
        {
            message = message = $"File formate is invalid on line {count}";
        }
    }
}
