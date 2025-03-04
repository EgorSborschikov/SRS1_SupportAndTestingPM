using Xunit;
using SRS1.Modules;
using Assert = Xunit.Assert;

namespace DefaultNamespace
{
    public class SubtractionTests
    {
        private readonly Substraction _subtraction;

        public SubtractionTests()
        {
            _subtraction = new Substraction();
        }

        [Fact]
        public void Subtract_PositiveNumbers_ReturnsDifference()
        {
            double result = _subtraction.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_NegativeNumbers_ReturnsDifference()
        {
            double result = _subtraction.Subtract(-5, -3);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Subtract_MixedNumbers_ReturnsDifference()
        {
            double result = _subtraction.Subtract(-5, 3);
            Assert.Equal(-8, result);
        }
    }
}