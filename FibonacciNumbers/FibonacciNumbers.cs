using System;

namespace FibonacciSequence
{
    public static class FibonacciNumbers
    {
        public static double Fibonacci(int n)
        {
            double root = Math.Sqrt(5);

            double fi_plus = (1 + root) / 2;

            double fi_minus = (1 - root) / 2;

            double result = (Math.Pow(fi_plus, n) - Math.Pow(fi_minus, n)) / root;

            return result;
        }

        public static double FibonacciSum(int n)
        {
            if (n < 3) return 1;         

            double one = 1, two = 1, sum = 0;

            for (int i = 0; i < (n - 2); i++)
            {
                sum = one + two;

                one = two;

                two = sum;
            }

            return sum;
        }
    }
}
