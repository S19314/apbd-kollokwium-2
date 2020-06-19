using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kollokwium_2.Exceptions
{
    public class IncorrectDateException : Exception
    {

        public IncorrectDateException(string message) : base(message)
        {
        }

        public IncorrectDateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IncorrectDateException()
        {
        }
    }
}
