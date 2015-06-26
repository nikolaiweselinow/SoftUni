using System;
using System.Linq;
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Title = "Problem 3.	Min, Max, Sum and Average of N Numbers";

        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("min = {0}", numbers.Min());
        Console.WriteLine("max = {0}", numbers.Max());
        Console.WriteLine("sum = {0}", numbers.Sum());
        Console.WriteLine("avg = {0:f2}", (double)numbers.Average());
    }
}

