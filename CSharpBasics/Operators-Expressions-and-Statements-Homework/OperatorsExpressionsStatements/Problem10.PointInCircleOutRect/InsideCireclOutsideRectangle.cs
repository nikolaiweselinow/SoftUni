using System;

class InsideCireclOutsideRectangle
{
    static void Main()
    {
        Console.Title = "Problem 10. Point Inside a Circle & Outside of a Rectangle";

        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        //(x - center_x)^2 + (y - center_y)^2 < radius^2

        bool isInCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
        bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (isInCirle && !isInRectangle)
        {
            Console.WriteLine("Is the point with coordinate ({0}, {1}) is inside a circle & outside of a rectangle? --->> Yes <<---", x, y);
        }
        else
        {
            Console.WriteLine("Is the point with coordinate ({0}, {1}) is inside a circle & outside of a rectangle? --->> No <<---", x, y);
        }

    }
}