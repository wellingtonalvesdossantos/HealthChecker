using HealthChecker.Core.Builders;
using HealthChecker.Core.Checkers;
using HealthChecker.Core.Types;
using MySql.Data.MySqlClient;

namespace HealthChecker.Core
{
    class MyService : IMyService
    {
        private readonly IConfigProvider _configProvider;
        private readonly ILogger _logger;

        public CheckerContainer HealthChecker
        {
            get
            {
                return new CheckerContainerBuilder()
                    .AddItem(new CheckerItem<string>(() => (string)_configProvider.Provide("defaultConnectionString"), e => !string.IsNullOrEmpty(e) /*DbConnectionChecker.CheckMySqlConn(e)*/))
                    .AddItem(new CheckerItem<bool?>(() => (bool?)_configProvider.Provide("logEnabled"), e => e != null))
                    .AddItem(new CheckerItem<string>(() => (string)_configProvider.Provide("welcomeMessage"), e => !string.IsNullOrEmpty(e), () => (bool)_configProvider.Provide("logEnabled")))
                    .Build();
            }
        }

        public MyService(IConfigProvider configProvider, ILogger logger)
        {
            _configProvider = configProvider;
            _logger = logger;
        }

        public void ExecuteMainProcess()
        {
            //var dbConnectionString = (string)_configProvider.Provide("defaultConnectionString");
            //using (var conn = new MySqlConnection(dbConnectionString))
            //{
            //    conn.Open();
            //}
            if ((bool)_configProvider.Provide("logEnabled"))
            {
                var welcomeMessage = (string)_configProvider.Provide("welcomeMessage");
                _logger.LogInfo(welcomeMessage); 
            }
        }
    }
}
