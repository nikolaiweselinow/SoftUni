using System;

class SumOfThreeNum
{
    static void Main()
    {
        Console.Title = "Problem 1.	Sum of 3 Numbers";

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        SumOfThreeNumber(a, b, c);
    }
    static void SumOfThreeNumber(double a, double b, double c)
    {
        double sum = a + b + c;
        Console.WriteLine(sum);
    }
}

