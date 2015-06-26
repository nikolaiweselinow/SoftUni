using System;

class Trapezoids
{
    static void Main()
    {
        Console.Title = "Problem 9. Trapezoids";
        
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("Trapezoid`s area: {0}", area);
    }
}