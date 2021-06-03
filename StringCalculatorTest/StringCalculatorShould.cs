using System;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorShould
    {
        [Fact]
        public void CalculateStringZero()
        {
            var stringCalculator = new StringCalculator();
            var calculateString = stringCalculator.Add("");

            Assert.Equal(0, calculateString);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        public void CalculateStringNumber(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            var calculateString = stringCalculator.Add(input);

            Assert.Equal(expected, calculateString);
        }
        
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,5", 8)]
        public void CalculateStringMultipleNumbers(string input, int expected)
        {
            var stringCalculator = new StringCalculator();
            var calculateString = stringCalculator.Add(input);

            Assert.Equal(expected, calculateString);
        }

        [Theory]
        [InlineData("1,2\n3",6)]
        [InlineData("3\n5\n3,9",20)]
        public void CalculateStringIgnoreNewLine(string input, int expected)
        {
            var stringCalculator =  new StringCalculator();
            var calculateString = stringCalculator.Add(input);

            Assert.Equal(expected, calculateString);
        }
    }
}