using System;
using System.Collections.Generic;
using System.Linq;


//Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
class SortingNumbers
{
    static void Main()
    {
        Console.Title = "Problem 5.	Sorting Numbers";

        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Array.Sort(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

