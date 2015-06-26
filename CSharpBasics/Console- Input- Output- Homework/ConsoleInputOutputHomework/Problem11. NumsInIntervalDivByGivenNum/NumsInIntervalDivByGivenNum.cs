using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.


class NumsInIntervalDivByGivenNum
{
    static void Main()
    {
        Console.Title = "Problem 11.	* Numbers in Interval Dividable by Given Number";

        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        Console.Write("Comments: ");
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write(i + " ");                
            }
        }
        Console.WriteLine();
        Console.WriteLine("Count numbers: {0}", counter);
    }
}

