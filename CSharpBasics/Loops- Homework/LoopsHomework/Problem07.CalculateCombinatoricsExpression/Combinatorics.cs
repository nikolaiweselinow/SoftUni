using System;


class Combinatorics
{
    static void Main()
    {
        Console.Title = "Problem 7.	Calculate N! / (K! * (N-K)!)";

        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());

        double nFactorial = 1;
        double kFactorial = 1;
        double nMinusKFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k) kFactorial = kFactorial * i;
            nFactorial = nFactorial * i;
        }

        for (int i = 1; i <= n - k; i++)
		{
            nMinusKFactorial = nMinusKFactorial * i;
		}      

        double result = (nFactorial / (kFactorial * nMinusKFactorial));

        Console.WriteLine(result);
    }
}

