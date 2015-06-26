using System;
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
class PointInACircle
{
    static void Main()
    {
        Console.Title = "Problem 7. Point in a Circle";

        Console.Write("x= ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y= ");
        double y = double.Parse(Console.ReadLine());

        bool isInCirle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(2, 2);

        Console.WriteLine("Is the point ({0}, {1}) is in cirle? --->> {2}", x, y, isInCirle);
    }
}