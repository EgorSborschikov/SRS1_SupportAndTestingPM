using Xunit;
using SRS1.Modules;
using System;
using Assert = Xunit.Assert;

namespace DefaultNamespace
{
    public class DivisionTests
    {
        private readonly Division _division;

        public DivisionTests()
        {
            _division = new Division();
        }

        [Fact]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            double result = _division.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            double result = _division.Divide(-6, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_MixedNumbers_ReturnsQuotient()
        {
            double result = _division.Divide(-6, 3);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _division.Divide(6, 0));
        }
    }
}