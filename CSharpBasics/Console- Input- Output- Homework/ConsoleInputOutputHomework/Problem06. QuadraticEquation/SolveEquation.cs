using System;

class SolveEquation
{
    public void SolveQuadratic(double a, double b, double c)
    {
        double determinant = b * b - 4 * a * c;
        double x, x1, x2;
        if (determinant > 0)
        {
            x1 = (-b - System.Math.Sqrt(determinant)) / (2 * a);
            x2 = (-b + System.Math.Sqrt(determinant)) / (2 * a);

            Console.WriteLine("Two real root:\nx1= {0}\nx2= {1}", x1, x2);
        }
        else if (determinant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else
        {
            x = (-b + System.Math.Sqrt(determinant)) / (2 * a);
            Console.WriteLine("One real root:\nx1=x2= {0}", x);
        }
    }
}

