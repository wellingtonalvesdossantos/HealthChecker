using Microsoft.Extensions.DependencyInjection;

namespace HealthChecker.Core
{
    public class DependencyRegistrator : IDependencyRegistrator
    {
        public static DependencyRegistrator _instance = null;

        public ServiceProvider ServiceProvider { get; private set; }

        private DependencyRegistrator()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IConfigProvider, ConfigProvider>();
            serviceCollection.AddScoped<ILogger, Logger>();
            serviceCollection.AddScoped<IMyService, MyService>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public static DependencyRegistrator GetInstance()
        {
            if (_instance == null) _instance = new DependencyRegistrator();
            return _instance;
        }
    }
}
