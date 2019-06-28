using BLL;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Utility;

namespace NUnitTest
{
    public class Tests
    {
        private IValueService _valueService;
        [SetUp]
        public void Setup()
        {
            var serviceProvider = Global.ServiceProvider;
            if (serviceProvider != null)
            {
                _valueService = serviceProvider.GetService<IValueService>();
            }

        }

        [Test]
        public void Values_test()
        {
            var resultSerice = _valueService.getValues();
            Assert.AreEqual("Value from Repository and Service", resultSerice);
        }
    }
}