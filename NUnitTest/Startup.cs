using IOC;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Utility;

namespace NUnitTest
{
    [SetUpFixture]
    public class Startup
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            IServiceCollection services = new ServiceCollection();
            IOCContainer.Build(services);
            Global.Services = services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {

        }
    }
}
