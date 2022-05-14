using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HealthChecker.Core
{
    public class ConfigProvider : IConfigProvider
    {
        private Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        public ConfigProvider()
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "sql10.freesqldatabase.com";
            builder.Port = 3306;
            builder.SslMode = MySqlSslMode.Disabled;
            builder.Database = "sql10439329";
            builder.UserID = "sql10439329";
            builder.Password = "q8t98g47if";
            var dbConnectionString = builder.ToString();

            _dictionary.Add("defaultConnectionString", dbConnectionString);
            _dictionary.Add("logEnabled", true);
            _dictionary.Add("welcomeMessage", "Hello world");
        }

        public object Provide(string key)
        {
            return _dictionary.TryGetValue(key, out object value) ? value : null;
        }
    }
}
