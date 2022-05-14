namespace HealthChecker.Core
{
    public interface IValidable<T>
    {
        void Validate(T value);
    }

    public interface IValidable
    {
        void Validate();
    }
}
