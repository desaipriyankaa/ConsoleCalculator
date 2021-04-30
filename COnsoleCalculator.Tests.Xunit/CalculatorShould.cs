using ConsoleCalculator;
using System;
using Xunit;

namespace COnsoleCalculator.Tests.Xunit
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenunsupportedOperation()
        {
            var sut = new Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            // this test doesn't passes

            // Assert.Throws<CalculationException>(
            //    () => sut.Calculate(1, 1, "+"));


            Assert.ThrowsAny<CalculationException>(
                () => sut.Calculate(1, 1, "+"));


            var ex = Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));
            Assert.Equal("+", ex.Operation);
        }
    }
}
