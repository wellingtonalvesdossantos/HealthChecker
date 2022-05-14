namespace HealthChecker.Core
{
    public interface ILogger
    {
        void LogError(string content);
        void LogInfo(string content);
        void LogWarning(string content);
    }
}