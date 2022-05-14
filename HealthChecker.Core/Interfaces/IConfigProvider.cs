namespace HealthChecker.Core
{
    public interface IConfigProvider
    {
        object Provide(string key);
    }
}