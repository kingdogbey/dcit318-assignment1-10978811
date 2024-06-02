// See https://aka.ms/new-console-template for more information
using System;

class TriangleType
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the sides of the triangle
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Determine the type of the triangle
        string triangleType = DetermineTriangleType(side1, side2, side3);

        // Display the result
        Console.WriteLine($"The triangle is {triangleType}.");
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}

