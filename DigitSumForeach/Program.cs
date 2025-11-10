using System;

namespace DigitSumForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                string digitString = c.ToString();
                int digit = int.Parse(digitString);
                sum += digit;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
