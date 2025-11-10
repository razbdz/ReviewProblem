using System;

namespace DecisionBasedOnBooleans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the lecture topic interesting?");
            bool interesting = Console.ReadLine() == "y";

            Console.WriteLine("Does one of your friends join?");
            bool friendJoins = Console.ReadLine() == "y";

            Console.WriteLine("Do you have problems with the assignment?");
            bool problems = Console.ReadLine() == "y";

            if (interesting && (friendJoins || problems))
            {
                Console.WriteLine("Go.");
            }
            else
            {
                Console.WriteLine("Stay.");
            }
        }
    }
}