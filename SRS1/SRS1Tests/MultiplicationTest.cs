using Xunit;
using SRS1.Modules;
using Assert = Xunit.Assert;

namespace DefaultNamespace
{
    public class MultiplicationTests
    {
        private readonly Multiplication _multiplication;

        public MultiplicationTests()
        {
            _multiplication = new Multiplication();
        }

        [Fact]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            double result = _multiplication.Multiply(3, 5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            double result = _multiplication.Multiply(-3, -5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Multiply_MixedNumbers_ReturnsProduct()
        {
            double result = _multiplication.Multiply(-3, 5);
            Assert.Equal(-15, result);
        }
    }
}