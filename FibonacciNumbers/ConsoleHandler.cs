using System;

namespace FibonacciSequence
{
    public class ConsoleHandler
    {
        public void CalculateNumber()
        {
            double number = 0;

            int position = GetPosition();

            try
            {
                number = FibonacciNumbers.Fibonacci(position);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write("Answer: {0}", number);
        }

        private int GetPosition()
        {
            Console.WriteLine("Please, enter a value");

            int.TryParse(Console.ReadLine(), out var result);

            return result;
        }
    }
}
