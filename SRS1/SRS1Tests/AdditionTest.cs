using Xunit;
using SRS1.Modules;
using Assert = Xunit.Assert;

namespace DefaultNamespace
{
    public class AdditionTests
    {
        private readonly Addition _addition;

        public AdditionTests()
        {
            _addition = new Addition();
        }

        [Fact]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            double result = _addition.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            double result = _addition.Add(-3, -5);
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_MixedNumbers_ReturnsSum()
        {
            double result = _addition.Add(-3, 5);
            Assert.Equal(2, result);
        }
    }
}