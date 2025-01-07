namespace MBX.Application.Contracts.Logging;

public interface IAppLogger
{
    void LogInformation(string message, params object[] args);
    void LogWarning(string message, params object[] args);
    void LogError(string message, params object[] args);
    void LogException(Exception exception, string message, params object[] args);
}