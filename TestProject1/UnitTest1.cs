using ConsoleCalculator;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var sut = new Calculator();
            //var result = sut.Calculate(1, 1, "+.");

            Assert.That(() => sut.Calculate(1, 1, "+."),
                 Throws.TypeOf<CalculationOperationNotSupportedException>());
        }
    }
}