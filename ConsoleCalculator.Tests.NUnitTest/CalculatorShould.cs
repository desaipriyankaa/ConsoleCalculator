using System;
using NUnit.Framework;

namespace ConsoleCalculator.Tests.NUnitTest
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenunsupportedOperation()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Calculate(1, 1, "+"),
                 Throws.TypeOf<CalculationOperationNotSupportedException>());


            Assert.That(() => sut.Calculate(1, 1, "+"),
                 Throws.TypeOf<CalculationOperationNotSupportedException>()
                 .With
                 .Property("Operation").EqualTo("+"));

            Assert.That(() => sut.Calculate(1, 1, "+"),
                 Throws.InstanceOf<CalculationException>());

            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
        }
    }
}
