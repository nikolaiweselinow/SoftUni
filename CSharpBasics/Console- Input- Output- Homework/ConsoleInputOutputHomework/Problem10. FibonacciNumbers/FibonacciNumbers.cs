using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Problem 10.	Fibonacci Numbers";


        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Please input a positive interger!");
            return;
        }

        int prevNum = -1;
        int nextNum = 1;
        int fibNum;


        for (int i = 0; i < n; i++)
        {
            fibNum = prevNum + nextNum;
            Console.Write("{0} ", fibNum);

            prevNum = nextNum;
            nextNum = fibNum;
        }
        Console.WriteLine();
    }
}
