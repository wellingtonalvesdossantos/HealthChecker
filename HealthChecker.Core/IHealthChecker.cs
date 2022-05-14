namespace HealthChecker.Core
{
    public interface IHealthChecker
    {
        CheckerContainer CheckerContainer { get; }
    }
}