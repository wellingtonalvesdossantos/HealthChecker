using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Core.ExtensionMethods
{
    public static class HealthCheckerExtensions
    {
        public static void CheckHealth(this IHealthChecker obj)
        {
            obj.HealthChecker.Validate();
        }
    }
}
