using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HealthChecker.Core
{
    public class CheckerContainer : ICheckerContainer
    {
        public List<ICheckerItem> Items { get; set; } = new List<ICheckerItem>();

        public void Validate()
        {
            foreach (var item in Items)
            {
                item.Validate();
            }
        }
    }
}
