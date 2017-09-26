using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapProviderCalculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        private ServiceCalculator calculator;

        [TestInitialize]
        public void SetUpCalculator()
        {
            calculator = new ServiceCalculator();
        }

        [TestMethod]
        public void AddMethodTest()
        {
            Assert.AreEqual(10, calculator.Add(5, 5));
        }
    }
}
