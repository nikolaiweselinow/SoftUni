using System;
//Problem 9.	Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class PrintASequence
{
    static void Main()
    {
        //first way
        int firstNumOfSeq = 2;
        int lenghtOfSeq = 10;

        for (int i = firstNumOfSeq; i < firstNumOfSeq + lenghtOfSeq; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}, ",i);
            }
            else
            {
                Console.Write("{0}, ", -i);
            }            
        }
        Console.WriteLine("\b\b ");
        Console.WriteLine(new string('=',40));




        //second way with Array
        int[] sequence = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                sequence[i] = i + 2;
            }
            else
            {
                sequence[i] = -(i + 2);
            }
        }
        Console.WriteLine(string.Join(", ", sequence));
    }
}

