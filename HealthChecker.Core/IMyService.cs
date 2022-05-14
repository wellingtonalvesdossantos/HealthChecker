namespace HealthChecker.Core
{
    public interface IMyService : IHealthChecker
    {
        void ExecuteMainProcess();
    }
}