using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kollokwium_2.Exceptions
{
    public class ArtistEventNotFoundException : Exception
    {

        public ArtistEventNotFoundException(string message) : base(message)
        {
        }

        public ArtistEventNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ArtistEventNotFoundException()
        {
        }
    }
}
