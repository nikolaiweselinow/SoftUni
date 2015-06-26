using System;
using System.Globalization;
using System.Threading;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Title = "Problem 3. Circle Perimeter and Area";
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //The user input 3.5 or 3,5 and don`t have exception

        Console.Write("Enter a radius: ");
        string radiusString = Console.ReadLine();
        radiusString = radiusString.Replace(",", ".");
        double radius = double.Parse(radiusString);

        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Radius = {0}", radius);
        Console.WriteLine("Perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Area = {0:0.00}", area);
    }
}