using System;

namespace FibonacciSequence
{
    public class ConsoleHandler
    {
        public void CalculateNumber()
        {
            int position = GetPosition();

            Console.Write("Answer: ");

            Console.WriteLine(FibonacciNumbers.Fibonacci(position));
        }

        private int GetPosition()
        {
            Console.WriteLine("Please, enter a value");

            int.TryParse(Console.ReadLine(), out var result);

            return result;
        }
    }
}
