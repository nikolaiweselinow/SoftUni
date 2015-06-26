using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.Title = "Problem 4. Rectangles";

        Console.Write("Enter value for WIDTH: ");
        double widht = double.Parse(Console.ReadLine());

        Console.Write("Enter value for HEIGHT: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (widht + height);
        double area = widht * height;

        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);
    }
}

