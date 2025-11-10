

using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine(first + second);
            Console.WriteLine(first * second);
            Console.WriteLine(first - second);
            Console.WriteLine(first / second);
            Console.WriteLine(first % second);
        }
    }
}





