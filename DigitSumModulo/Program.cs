using System;

namespace DigitSumModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                int remainder = number % 10;   // Get the last digit
                sum += remainder;              // Add it to the sum
                number = number / 10;          // Remove the last digit
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}

