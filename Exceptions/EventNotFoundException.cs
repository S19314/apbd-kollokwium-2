using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kollokwium_2.Exceptions
{
    public class EventNotFoundException : Exception
    {
        public EventNotFoundException(string message) : base(message)
        {
        }

        public EventNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public EventNotFoundException()
        {
        }
    }
}
