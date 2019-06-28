using API.Controllers;
using BLL;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Utility;

namespace NUnitTest
{
    public class Tests
    {
        private IValueService _valueService;
        private ValuesController _valueController;
        [SetUp]
        public void Setup()
        {
            var serviceProvider = Global.ServiceProvider;
            if (serviceProvider != null)
            {
                _valueService = serviceProvider.GetService<IValueService>();
                _valueController = new ValuesController(_valueService);
            }

        }

        [Test]
        public void ValuesService_test()
        {
            var resultSerice = _valueService.getValues();
            Assert.AreEqual("Value from Repository and Service", resultSerice);
        }

        [Test]
        public void ValuesController_test()
        {

            var resultController = _valueController.Get().Value;

            Assert.AreEqual("Value from Repository and Service", resultController);
        }
    }
}