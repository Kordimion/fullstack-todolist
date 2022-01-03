using System.Runtime.Serialization;

namespace TodoListExample.Core.Exceptions;

public class InvalidColorCode : Exception
{
    public InvalidColorCode() { }

    public InvalidColorCode(string message) : base(message) { }

    public InvalidColorCode(string message, Exception inner) : base(message, inner) { }

    protected InvalidColorCode(
        SerializationInfo info,
        StreamingContext context) : base(info, context) { }
}