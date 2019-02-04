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
    }
}
