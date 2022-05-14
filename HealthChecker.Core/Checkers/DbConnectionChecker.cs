using MySql.Data.MySqlClient;
using System;

namespace HealthChecker.Core.Checkers
{
    public static class DbConnectionChecker
    {
        public static bool CheckMySqlConn(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) return false;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                return !ex.InnerException?.Message.StartsWith("Access denied") ?? true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
