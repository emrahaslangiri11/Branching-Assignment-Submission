using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints welcome message for the shipping quote service
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Gets the weight of the package from user input
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Determines if the package weight exceeds the maximum allowable limit
            if (weight > 50)
            {
                // Shows rejection message for overweight packages
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Stops program execution for overweight packages
            }

            // Requests the width measurement of the package
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Requests the height measurement of the package
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Requests the length measurement of the package
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Evaluates if the total dimensions are acceptable for shipping
            if (width + height + length > 50)
            {
                // Displays message for packages with excessive dimensions
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Terminates the program for oversized packages
            }

            // Computes the shipping cost using the specified formula
            float quote = (height * width * length * weight) / 100;

            // Presents the calculated shipping cost to the customer
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Holds the console window open until user interaction
            Console.ReadKey();
        }
    }
}