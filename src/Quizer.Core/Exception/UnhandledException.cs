using System.Runtime.Serialization;

namespace Quizer.Core.Exception
{
    public class UnhandledException : System.Exception
    {
        public UnhandledException() : base() { }

        public UnhandledException(string message) : base(message) { }

        public UnhandledException(string message, System.Exception innerException) : base(message, innerException) { }

        public UnhandledException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    
    }
}
