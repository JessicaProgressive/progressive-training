using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class LoggerException : ApplicationException
    {
        private string _message;

        public LoggerException(string message)
        {
            _message = message;
        }
    }
}
