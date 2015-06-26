using System;
//Problem 8.	Square Root
//Create a console application that calculates and prints the square root of the number 12345. Find in Internet “how to calculate square root in C#”.

class SquareRoot
{
    static void Main()
    {
        //first way
        Console.WriteLine(Math.Sqrt(12345));

        Console.WriteLine(new string('=', 20));

        //second way

        double number = 12345;
        Console.WriteLine("The square root of the number {0} is {1}", number, Math.Sqrt(number));


    }
}

