using FluentValidation.Results;

namespace MBX.Application.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException() : base("Bad request.")
    {
    }

    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(ValidationResult validationResult)
        : base("Bad request. See validation errors for details.")
    {
        ValidationErrors = validationResult.Errors;
    }

    public BadRequestException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public List<ValidationFailure>? ValidationErrors { get; }
}