namespace HealthChecker.Core
{
    public class Logger : ILogger
    {
        public void LogInfo(string content) 
        {
            System.Diagnostics.Debug.WriteLine(content);
        }
        
        public void LogWarning(string content) { }
        public void LogError(string content) { }
    }
}
