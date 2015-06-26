using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Problem 6. Quadratic Equation";  
        
        Console.Write("a = ");
        string first = Console.ReadLine();
        first = first.Replace(",", ".");
        double a = double.Parse(first);

        Console.Write("b = ");
        string second = Console.ReadLine();
        second = second.Replace(",", ".");
        double b = double.Parse(second);
        
        Console.Write("c = ");
        string third = Console.ReadLine();
        third = third.Replace(",", ".");
        double c = double.Parse(third);       

        SolveEquation solveQuadraticEquation = new SolveEquation();
        solveQuadraticEquation.SolveQuadratic(a, b, c);
    }
}

