using System;
using System.Linq;

//Write a program that finds the biggest of three numbers

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Title = "Problem 5.	The Biggest of 3 Numbers";

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a, Math.Max(b, c)));
        
                
        //with "array" and System.Linq
        //Please uncomment (Mark a commented code and press CTRL + K + U)

        //double[] numbers = { a, b, c };
        //double biggestNum = numbers.Max();
        //Console.WriteLine(biggestNum);

        // With my method PrintBiggestNumber
        //Please uncomment the next row
        //PrintBiggestNumber(a, b, c);
    }

    static void PrintBiggestNumber(double x, double y, double z) 
    {
        double max = x;

        if (y > max)
        {
            max = y;
        }
        if (z > max)
        {
            max = z;            
        }

        Console.WriteLine(max);
    }
}


