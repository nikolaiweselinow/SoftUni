using System;
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Title = "Problem 9.	Matrix of Numbers";

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i + " ");

            for (int j = 2; j <= n; j++)
            {
                Console.Write(j + " ");
            }
            
        }
        Console.WriteLine();
    }
}

