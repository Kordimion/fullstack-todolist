using System.Runtime.Serialization;

namespace TodoListExample.Core.Exceptions;

public class UnsupportedColorCodeException : Exception
{
    public UnsupportedColorCodeException() { }

    public UnsupportedColorCodeException(string message) : base(message) { }

    public UnsupportedColorCodeException(string message, Exception inner) : base(message, inner) { }

    protected UnsupportedColorCodeException(
        SerializationInfo info,
        StreamingContext context) : base(info, context) { }
}