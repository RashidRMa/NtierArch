using System.Runtime.Serialization;

namespace Quizer.Core.Exception
{
    public class BadRequestException : System.Exception
    {

        public BadRequestException() : base() { }

        public BadRequestException(string message) : base(message) { }


        public BadRequestException(string message, System.Exception innerException) : base(message, innerException) { }
        public BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
