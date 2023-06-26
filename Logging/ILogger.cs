namespace BoltBit.Core.Logging;

public interface ILogger
{
    void LogInformation(string message);
    void LogWarning(string message);
    void LogError(string message, Exception? exception = null);
    void LogCritical(string message, Exception? exception = null);
}