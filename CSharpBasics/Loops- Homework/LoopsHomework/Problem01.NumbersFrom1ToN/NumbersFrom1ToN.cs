using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Title = "Problem 1.	Numbers from 1 to N";

        int n = int.Parse(Console.ReadLine());

        //with "for"
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);            
        }
        Console.WriteLine();

        //with "while"
        //Uncomment (Ctrl + K + U)

        //int j = 1;
        //while (j <= n)
        //{
        //    Console.Write("{0} ", j);
        //    j++;
        //}
        //Console.WriteLine();

    }
}



