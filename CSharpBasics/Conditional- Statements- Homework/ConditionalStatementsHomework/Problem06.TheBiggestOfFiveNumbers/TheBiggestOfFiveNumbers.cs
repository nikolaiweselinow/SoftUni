using System;
//Write a program that finds the biggest of five numbers by using only five if statements. 
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Title = "Problem 6.	The Biggest of Five Numbers";

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double max = a;

        // Only 4 IF statements!!!

        if (b > max)
            max = b;
        if (c > max)        
            max = c;        
        if (d > max)        
            max = d;       
        if (e > max)       
            max = e;
       
        Console.WriteLine(max);
    }
}

