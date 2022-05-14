using HealthChecker.Core;
using HealthChecker.Core.ExtensionMethods;
using NUnit.Framework;

namespace HealthChecker.UnitTest
{
    public class MyServiceTest
    {
        private IMyService _myService;

        [SetUp]
        public void Setup()
        {
            _myService = (IMyService)DependencyRegistrator.GetInstance().ServiceProvider.GetService(typeof(IMyService));
            _myService.CheckHealth();
        }

        [Test]
        public void ExecuteMainProcess()
        {
            //Arrange

            //Act
            _myService.ExecuteMainProcess();
        }
    }
}