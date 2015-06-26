using System;
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
class PrintLongSequence
{
    static void Main()
    {
        //int firstNumOfSeq = 2;
        //int lenghtOfSequence = 1000;

        int[] longSequence = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                longSequence[i] = i + 2 ;
            }
            else
            {
                longSequence[i] = -(i + 2);
            }
        }
        Console.WriteLine(string.Join(",", longSequence));        
    }
}
