using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a method Fib(n) that calculates the nth Fibonacci number. 
class FibNumbers
{
    public static int Fibonacii(int n) 
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        Console.Title = "Problem 1.	Fibonacci Numbers";

        Console.WriteLine(Fibonacii(int.Parse(Console.ReadLine())));
    }
}

