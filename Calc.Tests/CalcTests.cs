using System;
using Xunit;

namespace Calc.Tests
{
    public class CalcTests
    {
        [Fact]
        public void ZeroDivisionTest()
        {
            double a = 10, b = 0;
            string expected = "Error: Could not divide by zero!";
            string result = Program.Division(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10,2)]
        [InlineData(-13, 2)]
        [InlineData(13.7, 2.4)]
        [InlineData(-13.7, 2.4)]
        public void AdditionTest(double a, double b)
        {
            double expected = a + b;
            double result = Program.Addition(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(-13, 2)]
        [InlineData(13.7, 2.4)]
        [InlineData(-13.7, 2.4)]
        public void SubtractionTest(double a, double b)
        {
            double expected = a - b;
            double result = Program.Subtraction(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(-13, 2)]
        [InlineData(13.7, 2.4)]
        [InlineData(-13.7, 2.4)]
        public void MultiplicationTest(double a, double b)
        {
            double expected = a * b;
            double result = Program.Multiplication(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(-13, 2)]
        [InlineData(13.7, 2.4)]
        [InlineData(-13.7, 2.4)]
        public void DivisionTest(double a, double b)
        {
            string expected = (a / b).ToString();
            string result = Program.Division(a, b);

            Assert.Equal(expected, result);
        }
    }
}
