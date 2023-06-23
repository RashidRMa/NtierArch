using System.Runtime.Serialization;
using System;

namespace Quizer.Core.Exception
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException() : base() { }

        public NotFoundException(string message) : base(message) { }


        public NotFoundException(string message, System.Exception innerException) : base(message, innerException) { }
        public NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
