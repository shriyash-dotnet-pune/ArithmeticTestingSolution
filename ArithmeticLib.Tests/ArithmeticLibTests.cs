namespace ArithmeticLib.Tests
{
    public class ArithmeticLibTests
    {
        private readonly ArithmeticLib _arithmeticLib;
        public ArithmeticLibTests()
        {
            _arithmeticLib = new ArithmeticLib();
        }

        #region SumOfTwoNumbers Tests

        [Fact]
        public void SumOfTwoNumbers_PositiveNumbers_ReturnsCorrectSum()
        {
            int num1 = 10;
            int num2 = 20;
            int expected = 30;

            int result = _arithmeticLib.SumOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumOfTwoNumbers_NegativeNumbers_ReturnsCorrectSum()
        {
            int num1 = -10;
            int num2 = -20;
            int expected = -30;

            int result = _arithmeticLib.SumOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumOfTwoNumbers_ZeroValues_ReturnsZero()
        {
            int num1 = 0;
            int num2 = 0;
            int expected = 0;

            int result = _arithmeticLib.SumOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, 3, -2)]
        [InlineData(100, -50, 50)]
        public void SumOfTwoNumbers_MultipleInputs_ReturnsCorrectSum(int num1, int num2, int expected)
        {
            int result = _arithmeticLib.SumOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        #endregion

        #region DifferenceOfTwoNumbers Tests

        [Fact]
        public void DifferenceOfTwoNumbers_PositiveNumbers_ReturnsCorrectDifference()
        {
            int num1 = 20;
            int num2 = 10;
            int expected = 10;

            int result = _arithmeticLib.DifferenceOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DifferenceOfTwoNumbers_NegativeResult_ReturnsNegativeValue()
        {
            int num1 = 10;
            int num2 = 20;
            int expected = -10;

            int result = _arithmeticLib.DifferenceOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, 5, 10)]
        [InlineData(-10, -5, -5)]
        [InlineData(0, 0, 0)]
        public void DifferenceOfTwoNumbers_MultipleInputs_ReturnsCorrectDifference(int num1, int num2, int expected)
        {
            int result = _arithmeticLib.DifferenceOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        #endregion

        #region ProductOfTwoNumbers Tests

        [Fact]
        public void ProductOfTwoNumbers_PositiveNumbers_ReturnsCorrectProduct()
        {
            int num1 = 5;
            int num2 = 4;
            int expected = 20;

            int result = _arithmeticLib.ProductOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProductOfTwoNumbers_WithZero_ReturnsZero()
        {
            int num1 = 10;
            int num2 = 0;
            int expected = 0;

            int result = _arithmeticLib.ProductOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProductOfTwoNumbers_NegativeNumbers_ReturnsPositiveProduct()
        {
            int num1 = -5;
            int num2 = -4;
            int expected = 20;

            int result = _arithmeticLib.ProductOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 7, 21)]
        [InlineData(-3, 7, -21)]
        [InlineData(10, 10, 100)]
        public void ProductOfTwoNumbers_MultipleInputs_ReturnsCorrectProduct(int num1, int num2, int expected)
        {
            int result = _arithmeticLib.ProductOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        #endregion

        #region DivisionOfTwoNumbers Tests

        [Fact]
        public void DivisionOfTwoNumbers_ValidDivision_ReturnsCorrectQuotient()
        {
            int num1 = 20;
            int num2 = 4;
            double expected = 5.0;

            double result = _arithmeticLib.DivisionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivisionOfTwoNumbers_DivisionWithRemainder_ReturnsDecimal()
        {
            int num1 = 10;
            int num2 = 3;
            double expected = 3.333333333333333;

            double result = _arithmeticLib.DivisionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result, 10); 
        }

        [Fact]
        public void DivisionOfTwoNumbers_DivideByZero_ThrowsException()
        {
            int num1 = 10;
            int num2 = 0;

            Assert.Throws<DivideByZeroException>(() =>
                _arithmeticLib.DivisionOfTwoNumbers(num1, num2));
        }

        [Fact]
        public void DivisionOfTwoNumbers_NegativeNumbers_ReturnsNegativeQuotient()
        {
            int num1 = -20;
            int num2 = 4;
            double expected = -5.0;

            double result = _arithmeticLib.DivisionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(100, 10, 10.0)]
        [InlineData(15, 3, 5.0)]
        [InlineData(-50, 5, -10.0)]
        public void DivisionOfTwoNumbers_MultipleInputs_ReturnsCorrectQuotient(int num1, int num2, double expected)
        {
            double result = _arithmeticLib.DivisionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, result);
        }

        #endregion
    }
}