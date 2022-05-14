using System.Collections.Generic;

namespace HealthChecker.Core
{
    public interface ICheckerContainer : IValidable
    {
        List<ICheckerItem> Items { get; set; }
    }
}