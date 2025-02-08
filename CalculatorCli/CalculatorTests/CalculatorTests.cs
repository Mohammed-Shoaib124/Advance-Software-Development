using Calculator;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(1, -2, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(0, -1, -1)]
        public void Add_Tests(int a, int b, int expected)
        {
            int sum = Calculator.Calculator.Add(a, b);
            Assert.Equal(expected, sum);
        }

        [Fact]
        public void Add_ShouldThrowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Calculator.Add(int.MaxValue, 1));
        }

        [Fact]
        public void Divide_BaseCase()
        {
            double result = Calculator.Calculator.Divide(2, 1);
            Assert.Equal(2.0, result, 1);
        }
        [Fact]
        public void Divide_ShouldThrowException()
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.Calculator.Divide(2, 0));
        }
        [Fact]
        public void Subtract_BaseCase()
        {
            double result = Calculator.Calculator.Subtract(3, 1);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_OverflowException()
        {
            Assert.Throws<OverflowException>(() => Calculator.Calculator.Subtract(int.MaxValue, -1));
        }

        

        [Fact]
        public void Multiply_BaseCase()
        {
            double result = Calculator.Calculator.Multiply(3, 1);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Multiply_OverflowException()
        {
            Assert.Throws<OverflowException>(() => Calculator.Calculator.Multiply(int.MaxValue, 2));
        }
    }
}