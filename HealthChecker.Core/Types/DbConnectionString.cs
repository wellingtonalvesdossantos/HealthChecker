namespace HealthChecker.Core.Types
{
    public class DbConnectionString : SingleBase<string>
    {
        public DbConnectionString()
        {
        }

        public DbConnectionString(string value) : base(value)
        {
        }
    }
}
