using System;

namespace MultiplesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dividend");
            double dividend = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor");
            double divisor = double.Parse(Console.ReadLine());

            if (dividend % divisor == 0)
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("Not multiples");
            }
        }
    }
}
