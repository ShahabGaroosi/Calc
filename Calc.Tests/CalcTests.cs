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

        [Fact]
        public void AdditionTest2()
        {
            double[,] a = new double[4, 2] { { 2, 3 }, { 4, 7 }, { -8, 11 }, { -8, -11 } };
            double[] expected = new double[4] { 5, 11, 3, -19 };
            double[] result = Program.Addition(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractionTest2()
        {
            double[,] a = new double[4, 2] { { 2, 3 }, { 7, 4 }, { -8, 11 }, { -8, -11 } };
            double[] expected = new double[4] { -1, 3, -19, 3 };
            double[] result = Program.Subtraction(a);

            Assert.Equal(expected, result);
        }
    }
}
