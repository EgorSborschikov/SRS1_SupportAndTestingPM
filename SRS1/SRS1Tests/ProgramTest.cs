using System;
using Xunit;
using Assert = Xunit.Assert;

namespace SRS1.Tests
{
    public class ProgramTests
    {
        [NUnit.Framework.Theory]
        [InlineData(2, 3, "+", 5)]
        [InlineData(5, 3, "-", 2)]
        [InlineData(4, 2, "*", 8)]
        [InlineData(10, 2, "/", 5)]
        public void Calculate_ValidOperations_ReturnsExpectedResult(double number1, double number2, string operation, double expected)
        {
            // Act
            var result = Program.Calculate(number1, number2, operation);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [NUnit.Framework.Theory]
        [InlineData(10, 0, "/")]
        [InlineData(2, 3, "^")] // Неверная операция
        public void Calculate_InvalidOperations_ThrowsInvalidOperationException(double number1, double number2, string operation)
        {
            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => Program.Calculate(number1, number2, operation));
            Assert.Equal("Invalid operation selected.", exception.Message);
        }
    }
}