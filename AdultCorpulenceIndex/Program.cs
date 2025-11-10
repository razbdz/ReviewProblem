using System;

namespace AdultCorpulenceIndex
{
    class Program
    {
      
        static double ci(double mass, double height)
        {
            return mass / Math.Pow(height, 3);
        }

        static void Main(string[] args)
        {

            const double underWeightMax = 11.0;
            const double normalWeightMax = 14.0;
            const double overWeightMax = 17.0;
            const double moderateObeseMax = 22.0;
            const double severeObeseMax = 27.0;

       
            Console.WriteLine("Enter mass in kg");
            double mass = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height in m");
            double height = double.Parse(Console.ReadLine());

            
            double result = ci(mass, height);
            double roundedResult = Math.Round(result, 2);

            string category;

          
            if (roundedResult < underWeightMax)
            {
                category = "underweight";
            }
            else if (roundedResult < normalWeightMax)
            {
                category = "normal";
            }
            else if (roundedResult < overWeightMax)
            {
                category = "overweight";
            }
            else if (roundedResult < moderateObeseMax)
            {
                category = "moderately obese";
            }
            else if (roundedResult < severeObeseMax)
            {
                category = "severely obese";
            }
            else
            {
                category = "very severely obese";
            }

            Console.WriteLine($"Adults corpulence index of {roundedResult} means: {category}");
        }
    }
}
