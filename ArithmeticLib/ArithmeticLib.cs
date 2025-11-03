namespace ArithmeticLib
{
    public class ArithmeticLib
    {
        public int SumOfTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int DifferenceOfTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public int ProductOfTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public double DivisionOfTwoNumbers(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return (double)num1 / num2;
        }
    }
}