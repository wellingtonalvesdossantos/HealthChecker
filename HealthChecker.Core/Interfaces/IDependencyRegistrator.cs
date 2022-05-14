using Microsoft.Extensions.DependencyInjection;

namespace HealthChecker.Core
{
    public interface IDependencyRegistrator
    {
        ServiceProvider ServiceProvider { get; }
    }
}