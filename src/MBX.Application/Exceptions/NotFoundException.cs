namespace MBX.Application.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : base("Resource not found.")
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string name, object key) : base($"{name} with key ({key}) was not found.")
    {
    }

    public NotFoundException(string name, object key, Exception innerException)
        : base($"{name} with key ({key}) was not found.", innerException)
    {
    }

    public NotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}