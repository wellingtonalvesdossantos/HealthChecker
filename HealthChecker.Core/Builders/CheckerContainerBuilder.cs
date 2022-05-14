using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Core.Builders
{
    class CheckerContainerBuilder
    {
        private CheckerContainer _instance = new CheckerContainer();

        public CheckerContainerBuilder AddItem(ICheckerItem item)
        {
            _instance.Items.Add(item);
            return this;
        }

        public CheckerContainer Build()
        {
            return _instance;
        }
    }
}
