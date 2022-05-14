using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Core.Exceptions
{
    class HealthException : Exception
    {
        private readonly ICheckerItem _checkerItem;

        public HealthException(ICheckerItem checkerItem)
        {
            _checkerItem = checkerItem;
        }
    }
}
