using System;

class Program
{
    static void Main()
    {
        // Welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        double weight;
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input for weight.");
            return;
        }

        // Check if weight is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        double width;
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Invalid input for width.");
            return;
        }

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid input for height.");
            return;
        }

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        double length;
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input for length.");
            return;
        }

        // Check if dimensions exceed the maximum allowed size
        double dimensionSum = width + height + length;
        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the shipping quote
        // Formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Output the result formatted as a dollar amount
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
