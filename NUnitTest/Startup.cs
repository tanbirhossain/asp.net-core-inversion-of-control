using IOC;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using Utility;

namespace NUnitTest
{
    [SetUpFixture]
    public class Startup
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Global.ServiceProvider = ContainerBuilder();
        }

        public IServiceProvider ContainerBuilder()
        {
            IServiceCollection services = new ServiceCollection();
            //IOCContainer.Build(services);
            services.BuildContainer();
            return services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {

        }
    }
}
