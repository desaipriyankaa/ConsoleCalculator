using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenunsupportedOperation()
        {
            var sut = new Calculator();


            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.AreEqual("+", ex.Operation);
        }
    }
}
