using MBX.Application.Contracts.Logging;

using Microsoft.Extensions.Logging;

namespace MBX.Infrastructure.Logging;

public class AppLoggerAdapter<T> : IAppLogger
{
    private readonly ILogger<T> _logger;

    public AppLoggerAdapter(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<T>();
    }

    public void LogInformation(string message, params object[] args)
    {
        _logger.LogInformation(message, args);
    }

    public void LogWarning(string message, params object[] args)
    {
        _logger.LogWarning(message, args);
    }

    public void LogError(string message, params object[] args)
    {
        _logger.LogError(message, args);
    }

    public void LogException(Exception exception, string message, params object[] args)
    {
        _logger.LogError(exception, message, args);
    }
}