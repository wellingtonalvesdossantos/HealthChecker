using HealthChecker.Core.Exceptions;
using System;
using System.Linq.Expressions;

namespace HealthChecker.Core
{
    public class CheckerItem<T> : ICheckerItem
    {
        public Func<T> Func { get; set; }
        public Func<T, bool> IsHealthy { get; set; }
        public Func<bool> Condition { get; set; }

        public CheckerItem(Expression<Func<T>> funcExpression,
            Expression<Func<T, bool>> isHealthyExpression)
        {
            Func = funcExpression.Compile();
            IsHealthy = isHealthyExpression.Compile();
        }

        public CheckerItem(Expression<Func<T>> funcExpression, 
            Expression<Func<T, bool>> isHealthyExpression,
            Expression<Func<bool>> conditionExpression) : this(funcExpression, isHealthyExpression)
        {
            Condition = conditionExpression.Compile();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="HealthException"></exception>
        public void Validate()
        {
            var value = Func();
            if (Condition != null && !Condition()) 
                return;
            if (!IsHealthy(value))
                throw new HealthException(this);
        }
    }
}
