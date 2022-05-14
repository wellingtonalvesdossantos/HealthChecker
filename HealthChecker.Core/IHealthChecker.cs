namespace HealthChecker.Core
{
    public interface IHealthChecker
    {
        CheckerContainer HealthChecker { get; }
    }
}